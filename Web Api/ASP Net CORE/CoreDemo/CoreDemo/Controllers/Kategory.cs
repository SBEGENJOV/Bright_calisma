using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class Kategory : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
