using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using user_admin.Models;

namespace user_admin.Controllers
{
    public class PlazaController : Controller
    {
        // GET: Plaza
        Model1Container db=new Model1Container();
        public ActionResult Index()
        {
            var result = db.plazaSet.ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(plaza plaza)
        {
            try
            {
                using (Model1Container con = new Model1Container())
                {
                    con.plazaSet.Add(plaza);
                    con.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var result = db.plazaSet.Where(x => x.plazaNo == id).FirstOrDefault();
            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(int id, plaza plaza)
        {
            try
            {
                db.Entry(plaza).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var result = db.plazaSet.Where(x => x.plazaNo == id).FirstOrDefault();
            return View(result);
        }
        [HttpPost]
        public ActionResult Delete(int id, plaza plaza)
        {
            plaza = db.plazaSet.Where(x => x.plazaNo == id).FirstOrDefault();
            db.plazaSet.Remove(plaza);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}