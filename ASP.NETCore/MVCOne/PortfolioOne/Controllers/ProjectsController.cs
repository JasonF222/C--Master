using Microsoft.AspNetCore.Mvc;
namespace PortfolioOne.Controllers;

    public class Projects : Controller
    {
        [HttpGet]
        [Route("projects")]
        
        public string Project()
        {
            return "These are my projects!";
        }
    }