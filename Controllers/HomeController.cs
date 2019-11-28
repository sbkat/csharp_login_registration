using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using login_registration.Models;

namespace login_registration.Controllers
{
    public class HomeController : Controller
    {[HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost("register")]
    public IActionResult Register(Register newUser)
    {
        if(ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View("Index");
    }
    [HttpPost("login")]
    public IActionResult Login(Login existingUser)
    {
        if(ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View("Index");
    }
    [HttpGet("success")]
    public string Success()
    {
        return "Welcome, you have successfully logged in!";
    }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
