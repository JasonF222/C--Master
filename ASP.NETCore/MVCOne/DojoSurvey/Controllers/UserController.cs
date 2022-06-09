using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;
namespace DojoSurvey.Controllers;     //be sure to use your own project's namespace!

// When making Views folders, MATCH NAME OF CONTROLLER(i.e. UserController = User) //
    public class UserController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("survey")]
        public IActionResult Survey(Survey dojosurvey)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result", dojosurvey);
            }
            else
            {
                return Index();
            }
        }



        [HttpGet]
        [Route("results")]

        public IActionResult Result(Survey answer)
        {
            return View(answer);
        }
    }