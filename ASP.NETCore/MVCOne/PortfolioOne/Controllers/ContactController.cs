using Microsoft.AspNetCore.Mvc;
namespace PortfolioOne.Controllers;

public class Contact : Controller
{
    [HttpGet]
    [Route("contact")]

    public string ViewContact()
    {
        return "These are my contacts!";
    }
}