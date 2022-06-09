using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;
namespace ViewModelFun.Controllers;     //be sure to use your own project's namespace! //

// Views folders named AFTER Controller file (i.e Views -> Hello -> {route name here}.cshtml) //
public class HomeController : Controller   //remember inheritance?? //
{
    //for each route this controller is to handle: //
    // [HttpGet]       //type of request //
    // [Route("")]     //associated route string (exclude the leading /) //
    // public string Index()
    // {
    //     return "Hello World from HomeController!";
    // }

    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        string message = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Ipsum reiciendis eaque modi suscipit in nisi incidunt nemo expedita excepturi labore temporibus, magnam dignissimos quia officiis iure rerum. Minus, eum dicta.";
        return View("Index", message);
    }

    [HttpGet]
    [Route("numbers")]
    public IActionResult Numbers()
    {
        int[] numbers = new int[]
        {
            1,
            2,
            4,
            16,
            70,
            45
        };
        return View("Numbers", numbers);
    }

    [HttpGet]
    [Route("user_list")]
    public IActionResult UserList()
    {
        string[] names = new string[]
        {
            "John Wick",
            "Samurai Jack",
            "Geralt",
            "Yennifer",
            "Roach the Horse"
        };
        return View("UserList", names);
    }

    [HttpGet]
    [Route("single_user")]
    public IActionResult SingleUser()
    {
        User someUser = new User()
        {
            FirstName = "John",
            LastName = "Wick"
        };
        return View("SingleUser", someUser);
    }
}