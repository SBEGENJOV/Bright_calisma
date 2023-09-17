using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using user_admin.Models;

namespace user_admin.Controllers
{
    public class DepartmanTBController : Controller
    {
        Model1Container db = new Model1Container();
        // GET: DepartmanTB
        public ActionResult Index()
        {
            var result = db.depertmanSet.ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(depertman depertman)
        {
            try
            {
                db.depertmanSet.Add(depertman);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult Duzenle(int id)
        {
            var result = db.depertmanSet.Where(x => x.depertmanNo == id).FirstOrDefault();
            return View(result);
        }
        [HttpPost]
        public ActionResult Duzenle(int id, depertman depertman)
        {
            try
            {
                db.Entry(depertman).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }
        public ActionResult Sil(int id)
        {
            var result = db.depertmanSet.Where(x => x.depertmanNo == id).FirstOrDefault();
            return View(result);
        }
        [HttpPost]
        public ActionResult Sil(int id,depertman depertman)
        {
            var result = db.depertmanSet.Where(x => x.depertmanNo == id).FirstOrDefault();
            db.depertmanSet.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}