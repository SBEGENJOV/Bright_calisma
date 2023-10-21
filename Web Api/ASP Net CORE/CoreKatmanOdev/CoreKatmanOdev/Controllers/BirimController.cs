using CoreDataLayer.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CoreModelLayer.ViewModel;
using System.Collections.Generic;
using CoreModelLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreKatmanOdev.Controllers
{
    public class BirimController : Controller
    {
        public readonly ApplicationDbContext Context;
        public BirimController(ApplicationDbContext context)
        {
            this.Context = context;
        }
        public IActionResult Index(string a)
        {
            var result = (from b in Context.Birimlers
                          join g in Context.Gorevs on b.GorevNO equals g.GorevNO
                          select new ListView
                          {
                              BirimNO = b.BirimNO,
                              BirimAd = b.BirimAd,
                              BirimCalisanSayisi = b.BirimCalisanSayisi,
                              GorevNO = g.GorevNO,
                              GorevAd=g.GorevAd
                          }).ToList();
            if (a != null)
            {
                result = (from b in Context.Birimlers
                          join g in Context.Gorevs on b.GorevNO equals g.GorevNO
                          select new ListView
                          {
                              BirimNO = b.BirimNO,
                              BirimAd = b.BirimAd,
                              BirimCalisanSayisi = b.BirimCalisanSayisi,
                              GorevAd = g.GorevAd
                          }).Where(m => m.BirimAd.Contains(a)).ToList();
            }
            return View(result);
        }
        public IActionResult Create()
        {
            List<SelectListItem> datalar = (from x in Context.Gorevs.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.GorevTanimi,
                                                Value = x.GorevNO.ToString(),
                                            }).ToList();
            ViewBag.Datalar = datalar;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Birimler birimler)
        {
            Context.Birimlers.Add(birimler);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            List<SelectListItem> datalar = (from x in Context.Gorevs.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.GorevTanimi,
                                                Value = x.GorevNO.ToString(),
                                            }).ToList();
            ViewBag.data = datalar;
            return View(Context.Birimlers.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Birimler birimler)
        {
            Context.Update(birimler);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            string data=(from x in Context.Gorevs.ToList() select new
            {
                x.GorevTanimi
            }).ToString();
            ViewBag.datalar=data;
            return View(Context.Birimlers.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(Birimler birimler)
        {
            Context.Remove(birimler);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
