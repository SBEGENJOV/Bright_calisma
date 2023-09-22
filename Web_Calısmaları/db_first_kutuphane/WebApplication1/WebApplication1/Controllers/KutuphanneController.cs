using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class KutuphanneController : Controller
    {
        kutuphaneEntities db = new kutuphaneEntities();
        // GET: Kutuphanne
        public ActionResult Index()
        {
            var result = db.Kutuphane.Include(x => x.Sube).ToList();
            return View(result);
        }
        public ActionResult Yeni()
        {
            List<SelectListItem> datalar = (from x in db.Sube.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.subeAd,
                                                Value = x.subeID.ToString(),
                                            }).ToList();
            ViewBag.veri = datalar;
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Kutuphane kutuphane)
        {
            db.Kutuphane.Add(kutuphane);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            List<SelectListItem> veriler = (from x in db.Sube.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.subeAd,
                                                Value = x.subeID.ToString(),
                                            }).ToList();

            ViewBag.veri = veriler;
            return View(db.Kutuphane.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, Kutuphane kutuphane)
        {
            db.Entry(kutuphane).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(db.Kutuphane.Find(id));
        }
        [HttpPost]
        public ActionResult Delete(int id, Kutuphane kutuphane)
        {
            db.Kutuphane.Remove(db.Kutuphane.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}