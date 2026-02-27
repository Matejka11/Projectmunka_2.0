using Microsoft.AspNetCore.Mvc;

namespace Projectmunka.Controllers
{
    public class Rendeles : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
