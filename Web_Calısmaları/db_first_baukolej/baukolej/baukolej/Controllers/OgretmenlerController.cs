using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baukolej.Models;

namespace baukolej.Controllers
{
    [Authorize(Roles = "A")]
    public class OgretmenlerController : Controller
    {
        // GET: Ogretmenler
        bauKolejEntities1 db = new bauKolejEntities1();
        public ActionResult Index()
        {
            return View(db.Ogretmenler.ToList());
        }

        public ActionResult yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Ogretmenler ogretmenler)
        {
            try
            {
                db.Ogretmenler.Add(ogretmenler);
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
            var result = db.Ogretmenler.Find(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(int id, Ogretmenler ogretmenler)
        {
            try
            {
                db.Entry(ogretmenler).State = System.Data.Entity.EntityState.Modified;
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
            var result = db.Ogretmenler.Find(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Delete(int id, Ogretmenler ogretmenler)
        {
            var result = db.Ogretmenler.Find(id);
            db.Ogretmenler.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Detay(int id)
        {
            var result = db.Ogretmenler.Find(id);
            return View(result);
        }
    }
}