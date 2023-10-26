using model_first.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace model_first.Controllers
{
    public class UrunlerController : Controller
    {
        Model1Container db = new Model1Container();
        // GET: Urunler
        public ActionResult Index()
        {
            return View(db.UrunSet.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Urun urun)
        {
            db.UrunSet.Add(urun); 
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            return View(db.UrunSet.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(Urun urun)
        {
            db.Entry(urun).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            return View(db.UrunSet.Find(id));
        }
        [HttpPost]
        public ActionResult Delete(int id,Urun urun)
        {
            db.UrunSet.Remove(db.UrunSet.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}