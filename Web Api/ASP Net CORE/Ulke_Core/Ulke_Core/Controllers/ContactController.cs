using Microsoft.AspNetCore.Mvc;

namespace Ulke_Core.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
