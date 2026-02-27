using Microsoft.AspNetCore.Mvc;
using Projectmunka.Models;
using Projectmunka.Data;

public class KosarController : Controller
{
    private readonly RendelesDbContext _rendelesContext;
    private readonly TermekekDbContext _termekContext;

    public KosarController(
        RendelesDbContext rendelesContext,
        TermekekDbContext termekContext)
    {
        _rendelesContext = rendelesContext;
        _termekContext = termekContext;
    }

    public IActionResult Index()
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null)
            return RedirectToAction("Login", "Regisztraltak");

        var kosar = _rendelesContext.Kosar
            .Where(x => x.RegisztraltakId == userId.Value)
            .ToList();

        var termekek = _termekContext.Termekek.ToList();

        var model = kosar.Select(k => new
        {
            KosarId = k.Id,
            Termek = termekek.First(t => t.Id == k.TermekId),
            k.Mennyiseg
        }).ToList();

        ViewBag.Osszeg = model.Sum(x => x.Termek.Price * x.Mennyiseg);

        return View(model);
    }
    public IActionResult Torles(int id)
    {
        var item = _rendelesContext.Kosar.Find(id);
        if (item != null)
        {
            _rendelesContext.Kosar.Remove(item);
            _rendelesContext.SaveChanges();
        }

        return RedirectToAction("Index");
    }
    public IActionResult Veglegesites()
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null)
            return RedirectToAction("Login", "Regisztraltak");

        var kosar = _rendelesContext.Kosar
            .Where(x => x.RegisztraltakId == userId.Value)
            .ToList();

        foreach (var item in kosar)
        {
            var termek = _termekContext.Termekek.Find(item.TermekId);
            if (termek != null)
            {
                termek.Darab -= item.Mennyiseg;
            }
        }

        _termekContext.SaveChanges();

        var rendeles = new Rendeles
        {
            Name = HttpContext.Session.GetString("UserName"),
            telepules = "",
            utca = "",
            Kosar = kosar
        };

        _rendelesContext.Rendeles.Add(rendeles);

        _rendelesContext.Kosar.RemoveRange(kosar);

        _rendelesContext.SaveChanges();

        return RedirectToAction("Siker");
    }

    public IActionResult Siker()
    {
        return View();
    }
}