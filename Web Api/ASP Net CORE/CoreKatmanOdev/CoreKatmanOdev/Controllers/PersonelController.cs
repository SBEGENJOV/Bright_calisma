using CoreDataLayer.Data;
using CoreModelLayer.Model;
using CoreModelLayer.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CoreKatmanOdev.Controllers
{
    public class PersonelController : Controller
    {
        public readonly ApplicationDbContext Context;
        public PersonelController(ApplicationDbContext context)
        {
            this.Context = context;
        }
        public IActionResult Index(string a)
        {
            var result = (from p in Context.Personels
                          join g in Context.Gorevs on p.PersonelNO equals g.GorevNO join u in Context.Unvans on p.PersonelNO equals u.UnvanNO
                          select new ListView
                          {
                              PersonelNO = p.PersonelNO,
                              PersonelAdSoyad = p.PersonelAdSoyad,
                              PersonelBTarih = p.PersonelBTarih,
                              PersonelCinsiyet = p.PersonelCinsiyet,
                              PersonelMaas=p.PersonelMaas,
                              PersonelPrim=p.PersonelPrim,
                              PersonelVardiyeDurum=p.PersonelVardiyeDurum,
                              GorevNO = p.GorevNO,
                              GorevAd=g.GorevAd,
                              UnvanAd=u.UnvanAd,
                              UnvanNO = u.UnvanNO
                          }).ToList();
            if (a != null)
            {
                result = (from p in Context.Personels
                          join g in Context.Gorevs on p.PersonelNO equals g.GorevNO
                          join u in Context.Unvans on p.PersonelNO equals u.UnvanNO
                          select new ListView
                          {
                              PersonelNO = p.PersonelNO,
                              PersonelAdSoyad = p.PersonelAdSoyad,
                              PersonelBTarih = p.PersonelBTarih,
                              PersonelCinsiyet = p.PersonelCinsiyet,
                              PersonelMaas = p.PersonelMaas,
                              PersonelPrim = p.PersonelPrim,
                              PersonelVardiyeDurum = p.PersonelVardiyeDurum,
                              GorevNO = p.GorevNO,
                              GorevAd = g.GorevAd,
                              UnvanAd = u.UnvanAd,
                              UnvanNO = u.UnvanNO
                          }).Where(m => m.PersonelAdSoyad.Contains(a)).ToList();
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
            string data = (from x in Context.Gorevs.ToList()
                           select new
                           {
                               x.GorevTanimi
                           }).ToString();
            ViewBag.datalar = data;
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
