using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using LoginRegistration.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace LoginRegistration.Controllers;

public class HomeController : Controller
{

    private UserContext _context;

    public HomeController(UserContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [Route("/register")]
    public IActionResult RegisterUser(User newUser)
    {
        if(ModelState.IsValid)
        {
            if(_context.Users.Any(u => u.Email == newUser.Email))
            {
                ModelState.AddModelError("Email", "Email already in use!");
                return View("Index");
            }

            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
            _context.Add(newUser);
            _context.SaveChanges();
            User getUser = _context.Users.FirstOrDefault(g => g.Email == newUser.Email);
            HttpContext.Session.SetInt32("userID", getUser.UserId);
            return RedirectToAction("Success");
        }
        return View("Index");
    }

    [HttpPost]
    [Route("/login/submit")]
    public IActionResult LoginSubmit(LoginUser userSubmission)
    {
        if(ModelState.IsValid)
        {
            var userInDb = _context.Users.FirstOrDefault(u => u.Email == userSubmission.LogEmail);
            if(userInDb == null)
            {
                ModelState.AddModelError("Email", "Invalid Email/Password.");
                return View("Login");
            }

            var hasher = new PasswordHasher<LoginUser>();
            var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LogPassword);

            if(result == 0)
            {
                ModelState.AddModelError("Password", "Invalid Password.");
                return View("Login");
            }

            HttpContext.Session.SetInt32("userID", userInDb.UserId);
        return RedirectToAction("Success");
        }
        return View("Login");
    }

    [HttpGet]
    [Route("/login")]
    public IActionResult LogPage()
    {
        return View("Login");
    }

    [HttpGet]
    [Route("/success")]
    public IActionResult Success()
    {
        if(HttpContext.Session.GetInt32("userID") == null)
        {
            ViewBag.ErrorMessage = "You must login or register to view content.";
            return View("Login");
        }
        return View("Success");
    }

    [HttpGet]
    [Route("/logout")]
    public IActionResult LogoutUser()
    {
        HttpContext.Session.Clear();
        return View("Login");
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
