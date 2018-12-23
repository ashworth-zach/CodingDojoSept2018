using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Identity;
using chefdishes.Models;
using Microsoft.EntityFrameworkCore;
namespace chefdishes.Controllers
{
    public class HomeController : Controller
    {
        private AllContext dbContext;

        public HomeController(AllContext context)
        {
            dbContext = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            // var dishesChef = dbContext.dish.Include(x => x.Chef).ToList();
            List<Chef> AllChefs = dbContext.chef.ToList();
            foreach (var chef in AllChefs){
                int total = dbContext.dish.Where( x => x.Chefid == chef.Chefid).Count();
                chef.total=total;
            }
            ViewBag.AllChefs = AllChefs;
            return View();
        }
        [HttpGet("newchef")]
        public IActionResult newchefsplash()
        {
            return View("newChef");
        }
        [HttpPost("AddChef")]
        public IActionResult AddChef(Chef newChef)
        {
            if (ModelState.IsValid)
            {
                // take the userReg object and convert it to User, with a hashed pw
                Chef newerChef = new Chef
                {
                    firstname = newChef.firstname,
                    lastname = newChef.lastname,
                    dob = newChef.dob,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,

                };
                // save the new user with hashed pw
                dbContext.chef.Add(newerChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("newChef", newChef);
        }
        [HttpGet("dishes")]
        public IActionResult DishesSplash()
        {
            var dishesChef = dbContext.dish.Include(x => x.Chef).ToList();

            List<Dish> AllDishes = dbContext.dish.ToList();
            ViewBag.AllDishes = dishesChef;
            return View("Dishes");
        }
        [HttpGet("newdish")]
        public IActionResult NewDishSplash()
        {
            List<Chef> AllChefs = dbContext.chef.ToList();
            ViewBag.AllChefs = AllChefs;
            return View("newDish");
        }
        [HttpPost("AddDish")]
        public IActionResult AddDish(Dish newdish)
        {
            if (ModelState.IsValid)
            {
                Chef RetrievedChef = dbContext.chef.FirstOrDefault(x => x.Chefid == newdish.Chefid);
                newdish.Chef = RetrievedChef;
                // RetrievedChef.Dish.Add(newdish);
                Console.WriteLine(newdish.Chef.firstname+"========================================");
                dbContext.dish.Add(newdish);
                dbContext.SaveChanges();
                return RedirectToAction("DishesSplash");
            }
            return View("NewDish");
        }
    }
}