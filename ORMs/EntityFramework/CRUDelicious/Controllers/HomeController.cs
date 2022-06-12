using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Http;

namespace CRUDelicious.Controllers;

public class HomeController : Controller
{
    private DishContext _context;

    public HomeController(DishContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        List<Dish> allDishes = _context.Dishes.OrderByDescending(d => d.CreatedAt).ToList();

        return View(allDishes);
    }

    [HttpGet]
    [Route("/viewdish/{oneId}")]
    public IActionResult ViewDish(int oneId)
    {
        Dish oneDish = _context.Dishes.FirstOrDefault(o => o.DishId == oneId);
        return View(oneDish);
    }

    [HttpGet]
    [Route("/delete/{oneId}")]
    public IActionResult DeleteDish(int oneId)
    {
        Dish deleteDish = _context.Dishes.FirstOrDefault(d => d.DishId == oneId);
        _context.Dishes.Remove(deleteDish);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    [HttpGet]
    [Route("/edit/{oneId}")]
    public IActionResult EditDish(int oneId)
    {
        Dish editDish =_context.Dishes.FirstOrDefault(e => e.DishId == oneId);
        HttpContext.Session.SetInt32("oneId", oneId);
        return View("EditDish", editDish);
    }

    [HttpGet]
    [Route("/addadish")]

    public IActionResult AddDish()
    {
        return View("AddDish");
    }

    [HttpPost]
    [Route("/update")]
    public IActionResult UpdateDish(Dish editedDish)
    {
        int? tempId = HttpContext.Session.GetInt32("oneId");
        int oneId = Convert.ToInt32(tempId);
        Dish oneDish = _context.Dishes.FirstOrDefault(o => o.DishId == oneId);
        if(ModelState.IsValid)
        {
            oneDish.Name = editedDish.Name;
            oneDish.Chef = editedDish.Chef;
            oneDish.Tastiness = editedDish.Tastiness;
            oneDish.Calories = editedDish.Calories;
            oneDish.Description = editedDish.Description;
            oneDish.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View("EditDish", oneDish);
    }

    [HttpPost]
    [Route("/createdish")]

    public IActionResult CreateDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View ("AddDish");
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
