using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using brightideas.Models;
using Microsoft.EntityFrameworkCore;
namespace brightideas.Controllers
{
    public class HomeController : Controller
    {
        private Context dbContext;

        public HomeController(Context context)
        {
            dbContext = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("index");
        }
        [HttpPost("Register")]
        public IActionResult Register(UserRegistration userReg)
        {
            IndexViewModel LoginErrors = new IndexViewModel()
            {
                UserReg = userReg
            };
            if (ModelState.IsValid)
            {
                // take the userReg object and convert it to User, with a hashed pw

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                if (dbContext.user.Any(u => u.email == userReg.email))
                {
                    ModelState.AddModelError("email", "Email already in use!");
                    return View("index", LoginErrors);
                }
                User newUser = new User()
                {
                    alias = userReg.alias,
                    firstname = userReg.firstname,
                    lastname = userReg.lastname,
                    email = userReg.email,
                };
                newUser.password = Hasher.HashPassword(newUser, userReg.password); // hash pw
                dbContext.user.Add(newUser);
                // save the new user with hashed pw
                dbContext.SaveChanges();
                //NEGATIVE HUGE NUMBER BUG THIS IS MY WORKAROUND
                User user = dbContext.user.FirstOrDefault(x => x.email == newUser.email);
                HttpContext.Session.SetInt32("UserId", user.UserId);
                // Console.WriteLine(user.UserId + "  " + HttpContext.Session.GetInt32("UserId") + "++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                return RedirectToAction("Ideas");
            }

            return View("Index", LoginErrors);
        }

        [HttpPost("SubmitLogin")]
        public IActionResult SubmitLogin(UserLogin userLog)
        {
            if (ModelState.IsValid)
            {
                User CheckUser = dbContext.user.FirstOrDefault(x => x.email == userLog.email);
                if (CheckUser != null && userLog.password != null)
                {
                    // check if the password matches
                    var Hasher = new PasswordHasher<User>();
                    if (0 != Hasher.VerifyHashedPassword(CheckUser, CheckUser.password, userLog.password))
                    {
                        // if match, set id to session & redirect
                        HttpContext.Session.SetInt32("UserId", CheckUser.UserId);
                        return RedirectToAction("Ideas");
                    }
                }
            }
            IndexViewModel LoginErrors = new IndexViewModel()
            {
                UserLog = userLog
            };
            return View("Index", LoginErrors);
        }
        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
        [HttpGet("Ideas")]
        public IActionResult Ideas()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            int userId = HttpContext.Session.GetInt32("UserId") ?? default(int);
            ViewBag.Ideas = dbContext.idea.Include(x => x.likes).Include(y => y.user).OrderByDescending(x=>x.likes.Count).ToList();
            ViewBag.User = dbContext.user.FirstOrDefault(x => x.UserId == userId);
            return View("Ideas");
        }
        [HttpPost("NewIdea")]
        public IActionResult NewIdea(Idea idea)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            int userId = HttpContext.Session.GetInt32("UserId") ?? default(int);
            if (ModelState.IsValid)
            {
                idea.UserId = userId;
                dbContext.idea.Add(idea);
                dbContext.SaveChanges();
                return Redirect("/Ideas");
            }
            ViewBag.Ideas = dbContext.idea.Include(x => x.likes).Include(y => y.user).ToList();
            ViewBag.User = dbContext.user.FirstOrDefault(x => x.UserId == userId);
            return View("Ideas", idea);
        }
        [HttpGet("like/{postId}")]
        public IActionResult Like(int postId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            int userId = HttpContext.Session.GetInt32("UserId") ?? default(int);
            if (dbContext.like.Any(x => x.UserId == userId && x.IdeaId == postId))
            {
                return RedirectToAction("Ideas");
            }
            Like like = new Like()
            {
                UserId = userId,
                IdeaId = postId
            };
            dbContext.like.Add(like);
            dbContext.SaveChanges();
            return RedirectToAction("Ideas");
        }
        [HttpGet("delete/{postId}")]
        public IActionResult Delete(int postId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            int userId = HttpContext.Session.GetInt32("UserId") ?? default(int);
            Idea post = dbContext.idea.FirstOrDefault(x => x.IdeaId == postId);
            if (post.UserId != userId)
            {
                return RedirectToAction("Ideas");
            }
            List<Like> delete = dbContext.like.Where(x => x.IdeaId == postId).ToList();
            foreach (var x in delete)
            {
                dbContext.like.Remove(x);
            }
            dbContext.idea.Remove(post);
            dbContext.SaveChanges();
            return RedirectToAction("Ideas");
        }
        [HttpGet("show/{postId}")]
        public IActionResult Show(int postId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            int userId = HttpContext.Session.GetInt32("UserId") ?? default(int);
            ViewBag.Idea = dbContext.idea.FirstOrDefault(x => x.IdeaId == postId);
            ViewBag.User = dbContext.user.FirstOrDefault(x => x.UserId == userId);
            ViewBag.Likes = dbContext.like.Where(x => x.IdeaId == postId).Include(x => x.user);
            return View("ShowIdea");
        }
        [HttpGet("user/{id}")]
        public IActionResult ShowUser(int id)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.User=dbContext.user.FirstOrDefault(x=>x.UserId==id);
            ViewBag.Likes=dbContext.like.Where(x=>x.UserId==id).Count();
            ViewBag.Posts=dbContext.idea.Where(x=>x.UserId==id).Count();
            return View("ShowUser");
        }
    }

}