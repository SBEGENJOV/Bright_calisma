using Microsoft.AspNetCore.Mvc;

namespace Ulke_Core.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
