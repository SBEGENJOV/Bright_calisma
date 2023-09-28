using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    [Authorize (Roles = "Kütüphaneci,Güvenlikçi")]
    public class KitapController : Controller
    {
        // GET: Kitap
        kutuphaneEntities db = new kutuphaneEntities();
        public ActionResult Index(string x)
        {
            var search = from m in db.Kitap select m;
            if (x != null)
            {
                search = search.Where(m => m.kitapAd.Contains(x));
            }

            db.Kitap.Include(n => n.Kutuphane).ToList();
            return View(search);
        }
        public ActionResult Yeni()
        {
            List<SelectListItem> liste=(from x in db.Kutuphane select new SelectListItem
            {
                Text=x.kutuphaneAdi,
                Value=x.kutuphaneID.ToString()
            }).ToList();
            ViewBag.kit=liste;
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Kitap kitap)
        {
            
            db.Kitap.Add(kitap);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            List<SelectListItem> liste = (from x in db.Kutuphane
                                          select new SelectListItem
                                          {
                                              Text = x.kutuphaneAdi,
                                              Value = x.kutuphaneID.ToString()
                                          }).ToList();
            ViewBag.kit=liste;
            return View(db.Kitap.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, Kitap kitap)
        {
            db.Entry(kitap).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(db.Kitap.Find(id));
        }
        [HttpPost]

        public ActionResult Delete (int id,Kitap kitap)
        {
            db.Kitap.Remove(db.Kitap.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}