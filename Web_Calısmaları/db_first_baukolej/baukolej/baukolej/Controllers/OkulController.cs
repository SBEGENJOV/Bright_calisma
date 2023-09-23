using baukolej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baukolej.Controllers
{
    [Authorize(Roles ="A")]
    public class OkulController : Controller
    {
        bauKolejEntities1 db = new bauKolejEntities1();
        // GET: Okul
       

        public ActionResult Index(string x)
        {
            var search = from p in db.Okul select p;
            if (x != null)
            {
                search = search.Where(m => m.Adi.Contains(x));
            }
            return View(search.ToList());
        }

        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Okul okul)
        {
            db.Okul.Add(okul);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var result = db.Okul.Find(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(int id, Okul okul)
        {
            try
            {
                db.Entry(okul).State = System.Data.Entity.EntityState.Modified;
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
            var result = db.Okul.Find(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Delete(int id, Okul okul)
        {
            db.Okul.Remove(db.Okul.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}