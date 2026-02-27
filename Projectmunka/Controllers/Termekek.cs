using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projectmunka.Data;
using Projectmunka.Models;

public class TermekekController : Controller
{
    private readonly TermekekDbContext _termekContext;
    private readonly RendelesDbContext _rendelesContext;

    public TermekekController(
        TermekekDbContext termekContext,
        RendelesDbContext rendelesContext)
    {
        _termekContext = termekContext;
        _rendelesContext = rendelesContext;
    }

    public IActionResult Index()
    {
        return View(_termekContext.Termekek.ToList());
    }

    [HttpPost]
    public IActionResult Kosarba(int termekId, int mennyiseg)
    {
        var userId = HttpContext.Session.GetInt32("UserId");

        if (userId == null)
            return RedirectToAction("Login", "Regisztraltak");

        var kosar = new Kosar
        {
            RegisztraltakId = userId.Value,
            TermekId = termekId,
            Mennyiseg = mennyiseg
        };

        _rendelesContext.Kosar.Add(kosar);
        _rendelesContext.SaveChanges();

        return RedirectToAction("Index");
    }
}