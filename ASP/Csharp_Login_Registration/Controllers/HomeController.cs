using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Identity;
using loginregistration.Models;
using Microsoft.EntityFrameworkCore;
namespace loginregistration.Controllers
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
            return View("index");
        }
        [HttpGet("login")]
        public IActionResult LoginSplash()
        {
            return View("login");
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
                    return View("index");
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
                HttpContext.Session.SetInt32("UserId", newUser.Id);
                return RedirectToAction("Success");
            }
            return View("Index", userReg);
            // if (ModelState.IsValid)
            // {

            //     else{
            //         dbContext.user.Add(NewUser);
            //         return RedirectToAction("Success");
            //     }
            // }
            // return View("index");
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
                        HttpContext.Session.SetInt32("UserId", CheckUser.Id);
                        return RedirectToAction("Success");
                    }
                }
            }
            return View("login", userLog);
        }
        [HttpGet("success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetInt32("UserId") == null){
                return RedirectToAction("Index");
            }
            return View("success");
        }
        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}