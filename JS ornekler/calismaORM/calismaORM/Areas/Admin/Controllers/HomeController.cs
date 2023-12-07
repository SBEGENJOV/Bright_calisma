using calismaORM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace calismaORM.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}