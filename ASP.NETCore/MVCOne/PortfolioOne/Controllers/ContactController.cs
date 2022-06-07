using Microsoft.AspNetCore.Mvc;
namespace PortfolioOne.Controllers;

public class Contact : Controller
{
    [HttpGet]
    [Route("contact")]

    public ViewResult ViewContact()
    {
        return View();
    }
}