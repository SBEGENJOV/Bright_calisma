using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using user_admin.Models;

namespace user_admin.Controllers
{
    public class FirmaTBController : Controller
    {
        // GET: FirmaTB
        Model1Container db = new Model1Container();
        public ActionResult Index()
        {
            var result = db.firmaSet.ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult Yeni() 
        { 
            return View(); 
        }
        [HttpPost]
        public ActionResult Yeni(firma firma)
        {
            try
            {
                using (db)
                {
                    db.firmaSet.Add(firma);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
            
        }
        [HttpGet]
        public ActionResult Duzenle(int id)
        {
                    var result=db.firmaSet.Where(x=>x.firmaNo==id).FirstOrDefault();
                    return View(result);
        }
        [HttpPost]
        public ActionResult Duzenle(int id,firma firma)
        {
            try
            {
                db.Entry(firma).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Sil(int id)
        {
            var result = db.firmaSet.Where(x => x.firmaNo == id).FirstOrDefault();
            return View(result);
        }
        [HttpPost]
        public ActionResult Sil(int id,firma firma)
        {
            var result = db.firmaSet.Where(x => x.firmaNo == id).FirstOrDefault();
            db.firmaSet.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}