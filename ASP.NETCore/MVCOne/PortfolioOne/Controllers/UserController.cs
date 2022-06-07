using Microsoft.AspNetCore.Mvc;
namespace PortfolioOne.Controllers;
    public class UserController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "This is my Index!";
        }

    }