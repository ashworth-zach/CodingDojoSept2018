using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using formsubmit.Models;

namespace formsubmit.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("index");
        }
        [HttpPost("create")]
        public IActionResult Create(string firstname, string lastname, string email,string password, int age)
        {
            if (ModelState.IsValid)
            {
                Form user = new Form(firstname,lastname,email,password, age);
                return RedirectToAction("success");
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("");
            }
        }
        [HttpGet("success")]
        public IActionResult Success(){
            return View("success");
        }
    }
}
