using CoreDataLayer.Data;
using CoreModelLayer.Model;
using CoreModelLayer.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreKatmanOdev.Controllers
{
    public class ProjeController : Controller
    {
        public readonly ApplicationDbContext Context;
        public ProjeController(ApplicationDbContext context)
        {
            this.Context = context;
        }
        public IActionResult Index(string a)
        {
            var result = (from p in Context.Projes
                          join g in Context.Gorevs on p.ProjeNO equals g.GorevNO
                          select new ListView
                          {
                              ProjeNO= p.ProjeNO,
                              ProjeAd=p.ProjeAd,
                              BaslamaTarih= p.BaslamaTarih,
                              BitisTarih= p.BitisTarih,
                              GorevNO=g.GorevNO,
                              GorevAd = g.GorevAd
                          }).ToList();
            if (a != null)
            {
                result = (from p in Context.Projes
                          join g in Context.Gorevs on p.ProjeNO equals g.GorevNO
                          select new ListView
                          {
                              ProjeNO = p.ProjeNO,
                              ProjeAd = p.ProjeAd,
                              BaslamaTarih = p.BaslamaTarih,
                              BitisTarih = p.BitisTarih,
                              GorevNO = g.GorevNO,
                              GorevAd = g.GorevAd
                          }).Where(m => m.ProjeAd.Contains(a)).ToList();
            }
            return View(result);
        }
        public IActionResult Create()
        {
           return View();
        }
        [HttpPost]
        public IActionResult Create(Proje Proje)
        {
            Context.Projes.Add(Proje);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(Context.Projes.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Proje Proje)
        {
            Context.Update(Proje);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(Context.Projes.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(Proje Proje)
        {
            Context.Remove(Proje);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
