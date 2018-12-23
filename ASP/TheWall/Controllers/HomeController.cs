using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using TheWall.Models;
using Microsoft.EntityFrameworkCore;
namespace TheWall.Controllers
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
            lock (Console.Out)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
            }

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
                User newUser = new User
                {
                    firstname = userReg.firstname,
                    lastname = userReg.lastname,
                    email = userReg.email,
                };
                newUser.password = Hasher.HashPassword(newUser, userReg.password); // hash pw
                dbContext.user.Add(newUser);
                // save the new user with hashed pw
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                dbContext.SaveChanges();
                return RedirectToAction("Wall");
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
                        return RedirectToAction("Wall");
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
        [HttpGet("Wall")]
        public IActionResult Wall()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            
            int UserId = HttpContext.Session.GetInt32("UserId") ?? default(int);
            ViewBag.User= dbContext.user.FirstOrDefault(x=>x.UserId==UserId);
            ViewBag.MessagesComments = dbContext.user.Include(x=>x.messages).ThenInclude(y=>y.comments).ThenInclude(z=>z.user).ToList();
            return View("Wall");
        }
        [HttpPost("Message")]
        public IActionResult NewMessage(Message message)
        {
            int UserId = HttpContext.Session.GetInt32("UserId") ?? default(int);
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {

                message.UserId =UserId;
                dbContext.message.Add(message);
                dbContext.SaveChanges();
                return RedirectToAction("Wall");
            }
            ViewBag.User= dbContext.user.FirstOrDefault(x=>x.UserId==UserId);
            ViewBag.MessagesComments = dbContext.user.Include(x=>x.messages).ThenInclude(y=>y.comments).ToList();

            return View("Wall");
        }
        [HttpPost("Comment/{messageId}")]
        public IActionResult NewComment(Comment comment, int messageId)
        {
            int UserId = HttpContext.Session.GetInt32("UserId") ?? default(int);
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            comment.MessageId=messageId;
            if (ModelState.IsValid)
            {

                comment.UserId =UserId;
                dbContext.comment.Add(comment);
                dbContext.SaveChanges();
                return RedirectToAction("Wall");
            }
            ViewBag.User= dbContext.user.FirstOrDefault(x=>x.UserId==UserId);
            
            ViewBag.MessagesComments = dbContext.user.Include(x=>x.messages).ThenInclude(y=>y.comments).ToList();

            return View("Wall");
        }
    }

}