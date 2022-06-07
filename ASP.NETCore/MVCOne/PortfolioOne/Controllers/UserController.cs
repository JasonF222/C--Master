using Microsoft.AspNetCore.Mvc;
namespace PortfolioOne.Controllers;
    public class UserController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

    }