using baukolej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baukolej.Controllers
{
    public class OgrencilerController : Controller
    {
        bauKolejEntities1 db=new bauKolejEntities1();
        // GET: Ogrenciler
        public ActionResult Index()
        {
            return View(db.Ogrenciler.ToList());
        }

        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Ogrenciler ogrenciler)
        {
            try
            {
                db.Ogrenciler.Add(ogrenciler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
           var result=db.Ogrenciler.Find(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(int id, Ogrenciler ogrenciler)
        {
            try
            {
                db.Entry(ogrenciler).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var result = db.Ogrenciler.Find(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Delete(int id,Ogrenciler ogrenciler)
        {
            try
            {
                var result = db.Ogrenciler.Find(id);
                db.Ogrenciler.Remove(result);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}