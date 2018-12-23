
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;


namespace randompassword.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // int? attempt = HttpContext.Session.GetInt32("attempt");

            if (HttpContext.Session.GetInt32("attempt") == null)
            {
                HttpContext.Session.SetInt32("attempt", 1); 
            }
            else
            {
                int count = HttpContext.Session.GetInt32("attempt").GetValueOrDefault(); 
                HttpContext.Session.SetInt32("attempt", count + 1);
            }
            ViewBag.count=HttpContext.Session.GetInt32("attempt");
            Random rand = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var newstring = new char[14];
            for(int i = 0; i< newstring.Length;i++){
                newstring[i]=chars[rand.Next(0,36)];
            }
            string newString = new String(newstring);
            ViewBag.password=newString;
            return View("index");
        }
    }
}
