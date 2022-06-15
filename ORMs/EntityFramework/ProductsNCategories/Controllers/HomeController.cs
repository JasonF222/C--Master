using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsNCategories.Models;

namespace ProductsNCategories.Controllers;

public class HomeController : Controller
{

    private ProdCatContext _context;

    public HomeController(ProdCatContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("/")]
    public IActionResult ViewProducts()
    {
        ViewBag.ProdList = _context.Products.ToList();
        return View();
    }

    [HttpPost]
    [Route("/submit/product")]
    public IActionResult SubmitProduct(Product newProduct)
    {
        if(ModelState.IsValid)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("ViewProducts");
        }
        return View("ViewProducts");
    }

    [HttpGet]
    [Route("/view/product/{id}")]
    public IActionResult AddCategory(int id)
    {
        var OneProduct = _context.Products.Include(p => p.CatWithProd).ThenInclude(a => a.Category).FirstOrDefault(p => p.ProductId == id);
        ViewBag.CatList = _context.Categories.Include(c => c.ProdWithCat).Where(p => !p.ProdWithCat.Any(p => p.ProductId == id)).ToList();
        ViewBag.ProductId = id;
        return View("AddCategory", OneProduct);
    }

    [HttpGet]
    [Route("/view/categories")]
    public IActionResult ViewCategories()
    {
        ViewBag.CatList = _context.Categories.ToList();
        return View();
    }

    [HttpPost]
    [Route("/submit/category")]
    public IActionResult SubmitCategory(Category newCategory)
    {
        if(ModelState.IsValid)
        {
            _context.Categories.Add(newCategory);
            _context.SaveChanges();
            return RedirectToAction("ViewCategories");
        }
        return View("ViewCategories");
    }

    [HttpGet]
    [Route("/view/category/{id}")]
    public IActionResult AddProduct(int id)
    {
        var OneCategory = _context.Categories.Include(c => c.ProdWithCat).ThenInclude(a => a.Product).FirstOrDefault(c => c.CategoryId == id);
        ViewBag.ProdList = _context.Products.Include(p => p.CatWithProd).Where(c => !c.CatWithProd.Any(c => c.CategoryId == id)).ToList();
        ViewBag.CategoryId = id;
        return View("AddProduct", OneCategory);
    }

    [HttpPost]
    [Route("/submit/product/assoc/{id}")]
    public IActionResult SubmitNewProductAssoc(int id, Association newAssoc)
    {
        newAssoc.CategoryId = id;
        _context.Associations.Add(newAssoc);
        _context.SaveChanges();
        return RedirectToAction("ViewCategories");
    }

    [HttpPost]
    [Route("/submit/category/assoc/{id}")]
    public IActionResult SubmitNewCategoryAssoc(int id, Association newAssoc)
    {
        newAssoc.ProductId = id;
        _context.Associations.Add(newAssoc);
        _context.SaveChanges();
        return RedirectToAction("ViewProducts");
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
