using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Ulke_Core.Model;
using Ulke_Core.Models;

namespace Ulke_Core.Controllers
{
    public class KategoriController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public KategoriController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View(dbcontext.Kategoris.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Kategori kategori)
        {
            dbcontext.Kategoris.Add(kategori);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(dbcontext.Kategoris.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Kategori kategori)
        {
            dbcontext.Kategoris.Update(kategori);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(dbcontext.Kategoris.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(Kategori kategori)
        {
           dbcontext.Kategoris.Remove(kategori);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
