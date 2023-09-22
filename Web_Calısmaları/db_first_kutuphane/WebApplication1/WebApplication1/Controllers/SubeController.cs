using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.Entity;

namespace WebApplication1.Controllers
{

    public class SubeController : Controller
    {
        kutuphaneEntities db = new kutuphaneEntities();
        // GET: Sube
        public ActionResult Index()
        {
            return View(db.Sube.ToList());
        }
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Sube sube)
        {
            db.Sube.Add(sube);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var result = db.Sube.Find(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(int id, Sube sube)
        {
            db.Entry(sube).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var result = db.Sube.Find(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Delete(int id,Sube sube)
        {
            db.Sube.Remove(db.Sube.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}