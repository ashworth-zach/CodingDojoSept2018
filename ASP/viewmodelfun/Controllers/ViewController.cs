using Microsoft.AspNetCore.Mvc;
namespace viewmodelfun
{
    public class ViewController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Models.Message message = new Models.Message("blagb;ag;avl;sld;flasdlfajsdfkja;sldkjthisisamessagesaklsjdfja;slkdjfalksdjfaksdjfadlskjfa");
            return View("index", message);
        }
        [HttpGet("numbers")]
        public IActionResult Numbersplash()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 8, 7, 6, 54, 324, 234, 123, 23 };
            Models.Number numlist = new Models.Number(array);
            return View("numbers", numlist);
        }
        [HttpGet("users")]
        public IActionResult Usersplash()
        {
            string[] array = { "bob","joe","bill","billy","joe","billybobthethird"};
            Models.User peoplelist = new Models.User(array);
            return View("users", peoplelist);
        }
        [HttpGet("user")]
        public IActionResult User1splash()
        {
            string ppl = "billybobthethird";
            Models.User person = new Models.User(ppl);
            return View("user", person);
        }
    }
}