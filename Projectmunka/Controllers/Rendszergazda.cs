using Microsoft.AspNetCore.Mvc;
using Projectmunka.Data;
using Projectmunka.Models;

[Route("api/admin")]
[ApiController]
public class AdminController : ControllerBase
{
    private readonly TermekekDbContext _context;

    public AdminController(TermekekDbContext context)
    {
        _context = context;
    }

    private bool IsAdmin()
    {
        var email = HttpContext.Session.GetString("UserName");
        return email == "admin@admin.hu";
    }

    [HttpGet]
    public IActionResult Get()
    {
        if (!IsAdmin()) return Unauthorized();
        return Ok(_context.Termekek.ToList());
    }

    [HttpPost]
    public IActionResult Post(Termekek t)
    {
        if (!IsAdmin()) return Unauthorized();
        _context.Termekek.Add(t);
        _context.SaveChanges();
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (!IsAdmin()) return Unauthorized();

        var t = _context.Termekek.Find(id);
        if (t == null) return NotFound();

        _context.Termekek.Remove(t);
        _context.SaveChanges();
        return Ok();
    }
}