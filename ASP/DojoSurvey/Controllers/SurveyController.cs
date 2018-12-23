using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers     //be sure to use your own project's namespace!
{
    public class SurveyController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View("index");
        }
        [HttpPost]
        [Route("result")]
        public IActionResult Result(string firstname, string message, string location, string language){
            Models.Survey info = new Models.Survey(firstname,language,location,message);
            TryValidateModel(info);

            if (ModelState.IsValid)
            {
                return View("result",info);
            }
            else
            {
                return View("index");
            }
        }
    }
}