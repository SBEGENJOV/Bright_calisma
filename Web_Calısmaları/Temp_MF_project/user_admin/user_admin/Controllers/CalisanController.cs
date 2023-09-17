using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using user_admin.Models;

namespace user_admin.Controllers
{
    public class CalisanController : Controller
    {
        Model1Container db = new Model1Container();
        // GET: Calisan
        public ActionResult Index()
        {
            var result = db.calisanSet.ToList();
            return View(result);
        }
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(calisan calisan)
        {
            db.calisanSet.Add(calisan);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Duzenle(int id)
        {
            var result = db.calisanSet.Where(x => x.calisanNo == id).FirstOrDefault();
            return View(result);
        }
        [HttpPost]
        public ActionResult Duzenle(int id, calisan calisan)
        {
            try
            {
                db.Entry(calisan).State = System.Data.Entity.EntityState.Modified;
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