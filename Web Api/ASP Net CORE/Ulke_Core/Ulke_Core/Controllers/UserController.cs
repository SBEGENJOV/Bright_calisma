using Microsoft.AspNetCore.Mvc;

namespace Ulke_Core.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
