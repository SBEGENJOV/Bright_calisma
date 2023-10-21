using CoreDataLayer.Data;
using CoreModelLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreKatmanOdev.Controllers
{
    public class UnvanController : Controller
    {
        public readonly ApplicationDbContext Context;
        public UnvanController(ApplicationDbContext context)
        {
            this.Context = context;
        }
        public IActionResult Index(string x)
        {
            var resault = from a in Context.Unvans select a;
            if (x!=null)
            {
             resault=resault.Where(d=>d.UnvanAd.Contains(x));
            }
            return View(resault);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Unvan unvan)
        {
            Context.Unvans.Add(unvan);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(Context.Unvans.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Unvan unvan) 
        {
            Context.Update(unvan);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(Context.Unvans.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(Unvan unvan)
        {
            Context.Remove(unvan);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
