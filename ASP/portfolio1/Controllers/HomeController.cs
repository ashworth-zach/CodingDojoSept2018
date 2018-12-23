using Microsoft.AspNetCore.Mvc;
namespace portfolio1
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public string Index(){
            return "This is my useless index";
        }
        [HttpGet("projects")]
        public string Projects(){
            return "these are my projects";
        }
        [HttpGet("contact")]
        public string Contact(){
            return "this is my contact info (not really)";
        }
    }
}