using CoreDataLayer.Data;
using CoreModelLayer.Model;
using CoreModelLayer.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CoreKatmanOdev.Controllers
{
    public class GorevController : Controller
    {
        public readonly ApplicationDbContext Context;
        public GorevController(ApplicationDbContext context)
        {
            this.Context = context;
        }
        public IActionResult Index(string kelime)
        {
            var resault= (from g in Context.Gorevs join p in Context.Projes on g.GorevNO equals p.ProjeNO select new ListView
            {
               GorevTanimi=g.GorevTanimi,
               GorevAd=g.GorevAd,
               GorevPuan=g.GorevPuan,
               GorevNO=g.GorevNO,
               ProjeNO=p.ProjeNO,
               ProjeAd=p.ProjeAd
            }).ToList();
            if (kelime!=null)
            {
                resault = (from g in Context.Gorevs
                           join p in Context.Projes on g.GorevNO equals p.ProjeNO
                           select new ListView
                           {
                               GorevTanimi = g.GorevTanimi,
                               GorevAd = g.GorevAd,
                               GorevPuan = g.GorevPuan,
                               GorevNO = g.GorevNO,
                               ProjeNO = p.ProjeNO,
                               ProjeAd = p.ProjeAd
                           }).Where(m=>m.GorevTanimi.Contains(kelime)).ToList();
            }
            return View(resault);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Gorev gorev)
        {
            Context.Gorevs.Add(gorev);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(Context.Gorevs.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Gorev gorev)
        {
            Context.Update(gorev);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(Context.Gorevs.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(Gorev gorev)
        {
            Context.Remove(gorev);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
