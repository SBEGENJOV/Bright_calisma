using Microsoft.AspNetCore.Mvc;

namespace Ulke_Core.Controllers
{
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
