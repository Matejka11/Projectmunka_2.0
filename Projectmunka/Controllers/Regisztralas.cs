using Microsoft.AspNetCore.Mvc;
using Projectmunka.Data;
using Projectmunka.Models;

public class RegisztraltakController : Controller
{
    private readonly RegisztraltakDbContext _context;

    public RegisztraltakController(RegisztraltakDbContext context)
    {
        _context = context;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(Regisztraltak model)
    {
        if (ModelState.IsValid)
        {
            model.IsRegistered = true;
            _context.Regisztraltak.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }
        return View(model);
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        var user = _context.Regisztraltak
            .FirstOrDefault(x => x.email == email && x.password == password);

        if (user != null)
        {
            HttpContext.Session.SetInt32("UserId", user.Id);
            HttpContext.Session.SetString("UserName", user.Neve);
            return RedirectToAction("Index", "Termekek");
        }

        ViewBag.Error = "Hibás bejelentkezés!";
        return View();
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }
}