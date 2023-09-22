using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    public class CalisController : Controller
    {
        kutuphaneEntities db = new kutuphaneEntities();
        // GET: Calis
        public ActionResult Index()
        {
            var result = db.Calisanlar.Include(m => m.Kutuphane).ToList();
            return View(result);
        }
        public ActionResult Yeni()
        {
            List<SelectListItem> liste = (from x in db.Kutuphane.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.kutuphaneAdi,
                                              Value = x.kutuphaneID.ToString()
                                          }).ToList();
            ViewBag.veri = liste;
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Calisanlar calisanlar)
        {
            db.Calisanlar.Add(calisanlar);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            List<SelectListItem> liste = (from x in db.Kutuphane.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.kutuphaneAdi,
                                              Value = x.kutuphaneID.ToString()
                                          }).ToList();
            ViewBag.veri = liste;

            return View(db.Calisanlar.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, Calisanlar calisanlar)
        {
            db.Entry(calisanlar).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(db.Calisanlar.Find(id));
        }

        [HttpPost]
        public ActionResult Delete(int id,Calisanlar calisanlar)
        {
            
            db.Calisanlar.Remove(db.Calisanlar.Find(id));
            
            return RedirectToAction("Index");
        }
    }
}