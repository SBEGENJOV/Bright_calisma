using BusinessLayer.Concreate;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class KategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfKategoryRepostory());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
