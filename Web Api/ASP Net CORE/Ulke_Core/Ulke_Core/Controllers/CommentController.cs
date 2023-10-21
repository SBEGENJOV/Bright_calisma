using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Ulke_Core.Model;
using Ulke_Core.Models;

namespace Ulke_Core.Controllers
{
    public class CommentController : Controller
    {
        public readonly ApplicationDbContext dbContext;
        public CommentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View(dbContext.Comments.Include("Blog").ToList());
        }
        public IActionResult Create()
        {
            ViewData["BlogId"] = new SelectList(dbContext.Blogs, "BlogId", "BlogTitle");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Comment comment)
        {
            dbContext.Comments.Add(comment);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            ViewData["BlogId"] = new SelectList(dbContext.Blogs,"BlogId", "BlogTitle");
            return View(dbContext.Comments.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(Comment comment)
        {
            dbContext.Comments.Remove(comment);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            ViewData["BlogId"] = new SelectList(dbContext.Blogs, "BlogId", "BlogTitle");
            return View(dbContext.Comments.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Comment comment)
        {
            dbContext.Comments.Update(comment);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
