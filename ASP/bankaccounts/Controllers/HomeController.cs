using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Identity;
using bankaccounts.Models;
using Microsoft.EntityFrameworkCore;
namespace bankaccounts.Controllers
{
    public class HomeController : Controller
    {
        private UserContext dbContext;

        public HomeController(UserContext context)
        {
            dbContext = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Register");
        }
        [HttpGet("login")]
        public IActionResult LoginSplash()
        {
            return View("Login");
        }
        [HttpPost("register")]
        public IActionResult Register(User userReg)
        {
            if (ModelState.IsValid)
            {
                // take the userReg object and convert it to User, with a hashed pw
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                if (dbContext.user.Any(u => u.email == userReg.email))
                {
                    ModelState.AddModelError("email", "Email already in use!");
                    return View("Register");
                }
                User newUser = new User
                {
                    firstname = userReg.firstname,
                    lastname = userReg.lastname,
                    email = userReg.email,
                    password = Hasher.HashPassword(userReg, userReg.password), // hash pw
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                // save the new user with hashed pw
                dbContext.user.Add(newUser);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                return RedirectToAction("Success");
            }
            return View("Register", userReg);
        }

        [HttpPost]
        [Route("login")]
        public IActionResult SubmitLogin(UserLogin userLog)
        {
            if (ModelState.IsValid)
            {
                var CheckUser = dbContext.user.SingleOrDefault(x => x.email == userLog.email);
                if (CheckUser != null && userLog.password != null)
                {
                    // check if the password matches
                    var Hasher = new PasswordHasher<User>();
                    if (0 != Hasher.VerifyHashedPassword(CheckUser, CheckUser.password, userLog.password))
                    {
                        // if match, set id to session & redirect
                        HttpContext.Session.SetInt32("UserId", CheckUser.UserId);
                        return RedirectToAction("Success");
                    }
                }
            }
            return View("login", userLog);
        }
        [HttpGet("success")]
        public IActionResult Success()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            User user = dbContext.user.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            return Redirect("Account/" + user.UserId);
        }
        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Account/{user_id}")]
        public IActionResult ViewAccount(int user_id)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            if (HttpContext.Session.GetInt32("UserId") != user_id)
            {
                int? UserId = HttpContext.Session.GetInt32("UserId");
                return Redirect($"/Account/{UserId}");
            }
            User currentuser = dbContext.user.Include(user => user.Transactions).Where(user => user.UserId == user_id).SingleOrDefault();
            if (currentuser.Transactions != null)
            {
                currentuser.Transactions = currentuser.Transactions.OrderByDescending(trans => trans.created_at).ToList();
            }
            ViewBag.UserInfo = currentuser;
            return View();
        }
        [HttpPost]
        [Route("Transaction")]
        public IActionResult Transaction(float Amount, string Type)
        {
            int? user_id = HttpContext.Session.GetInt32("UserId");
            User CurrentUser = dbContext.user.FirstOrDefault(x => x.UserId == HttpContext.Session.GetInt32("UserId"));
            if (Type == "Withdraw")
            {
                if (CurrentUser.Cash - Amount < 0)
                {
                    ViewBag.errors = "Insufficient Funds";
                }
                else
                {
                    Transaction NewTransaction = new Transaction
                    {
                        amount = -Amount,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now,
                        UserId = CurrentUser.UserId,
                        User = CurrentUser
                    };
                    CurrentUser.Cash -= Amount;
                    dbContext.transaction.Add(NewTransaction);
                    dbContext.SaveChanges();
                }
            }
            if (Type == "Deposit")
            {
                Transaction NewTransaction = new Transaction
                {
                    amount = Amount,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                    UserId = CurrentUser.UserId,
                    User = CurrentUser
                };
                CurrentUser.Cash += Amount;
                dbContext.transaction.Add(NewTransaction);
                dbContext.SaveChanges();
            }
            ViewBag.UserInfo=CurrentUser;
            return Redirect($"Account/{user_id}");
        }
    }
}