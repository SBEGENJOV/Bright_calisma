using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Ulke_Core.Model;
using Ulke_Core.Models;

namespace Ulke_Core.Controllers
{
    public class BlogController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public BlogController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            var result = dbcontext.Blogs.Include("Kategori").ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            ViewData["KategoriID"] = new SelectList(dbcontext.Kategoris, "KategoriID", "KategoriName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            dbcontext.Blogs.Add(blog);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            dbcontext.Comments.Include("Blog").ToList();
            return View(dbcontext.Blogs.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(Blog blog)
        {
            dbcontext.Blogs.Remove(blog);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewData["KategoriID"] = new SelectList(dbcontext.Kategoris, "KategoriID", "KategoriName");
            return View(dbcontext.Blogs.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Blog blog)
        {
            dbcontext.Blogs.Update(blog);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
