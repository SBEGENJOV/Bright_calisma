using Microsoft.AspNetCore.Mvc;

namespace Ulke_Core.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
