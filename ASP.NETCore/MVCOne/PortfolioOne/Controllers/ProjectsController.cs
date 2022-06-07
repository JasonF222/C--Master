using Microsoft.AspNetCore.Mvc;
namespace PortfolioOne.Controllers;

    public class Projects : Controller
    {
        [HttpGet]
        [Route("projects")]
        
        public ViewResult Project()
        {
            return View();
        }
    }