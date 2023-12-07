using BusinessLayer.Concreate;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm=new BlogManager(new EfBlogRepostory());
        public IActionResult Index()
        {
            return View(bm.GetBlogListWithKategory());
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;
            var values=bm.GetBlogById(id);
            return View(values);
        }
    }
}
