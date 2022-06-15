using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers;

public class HomeController : Controller
{

    private ChefContext _context;

    public HomeController(ChefContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        List<Chef> allChefs = _context.Chefs.OrderBy(c => c.FirstName).Include(c => c.CreatedDishes).ToList();

        return View(allChefs);
    }

    [HttpGet]
    [Route("/dishes")]

    public IActionResult Dishes()
    {
        List<Dish> allDishes = _context.Dishes.OrderBy(d => d.Tastiness).Include(d => d.Creator).ToList();
        return View(allDishes);
    }

    [HttpGet]
    [Route("/new/chef")]
    
    public IActionResult NewChef()
    {
        return View();
    }

    [HttpGet]
    [Route("/new/dish")]
    
    public IActionResult NewDish()
    {
        List<Chef> chefList = _context.Chefs.ToList();
        ViewBag.ChefList = chefList;
        return View();
    }

    [HttpPost]
    [Route("/addchef")]

    public IActionResult AddChef(Chef newChef)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View("NewChef");
    }

    [HttpPost]
    [Route("/submit/dish")]

    public IActionResult SubmitDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Dishes");
        }
        List<Chef> chefList = _context.Chefs.ToList();
        ViewBag.ChefList = chefList;
        return View("NewDish");
    }














    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
