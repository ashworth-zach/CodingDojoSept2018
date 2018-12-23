using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    }
}