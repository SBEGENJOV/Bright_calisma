using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = "Kütüphaneci")]
    public class OgrenciiController : Controller
    {
        kutuphaneEntities db = new kutuphaneEntities();
        public ActionResult Index( string x)
        {
            var search = from m in db.Ogrenciler select m;
            if (x != null)
            {
                search = search.Where(m => m.ogrenciAdSoyad.Contains(x));
            }

            var result = db.Ogrenciler.Include(nx => nx.Kutuphane).Include(nx => nx.Calisma).ToList();
            return View(search);
        }

        public ActionResult Yeni()
        {
            List<SelectListItem> liste = (from x in db.Kutuphane
                                          select new SelectListItem
                                          {
                                              Text = x.kutuphaneAdi,
                                              Value = x.kutuphaneID.ToString()
                                          }).ToList();

            List<SelectListItem> liste1 = (from x in db.Calisma
                                           select new SelectListItem
                                           {
                                               Text = x.masaAd,
                                               Value = x.masaID.ToString()
                                           }).ToList();
            ViewBag.kutup = liste;
            ViewBag.masa = liste1;
            return View();
        }
        [HttpPost]

        public ActionResult Yeni(Ogrenciler ogrenciler)
        {
            db.Ogrenciler.Add(ogrenciler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            List<SelectListItem> kliste = (from x in db.Kutuphane
                                           select new
                                        SelectListItem
                                           {
                                               Text = x.kutuphaneAdi,
                                               Value = x.kutuphaneID.ToString()
                                           }).ToList();

            List<SelectListItem> mliste = (from x in db.Calisma
                                           select new SelectListItem
                                           {
                                               Text = x.masaAd,
                                               Value = x.masaID.ToString()
                                           }).ToList();

            ViewBag.klis = kliste;
            ViewBag.mlist= mliste;

            return View(db.Ogrenciler.Find(id));
        }
        [HttpPost]

        public ActionResult Edit(int id, Ogrenciler ogrenciler)
        {
            db.Entry(ogrenciler).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(db.Ogrenciler.Find(id));
        }

        [HttpPost]
        public ActionResult Delete(int id,Ogrenciler ogrenciler)
        {
            db.Ogrenciler.Remove(db.Ogrenciler.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}