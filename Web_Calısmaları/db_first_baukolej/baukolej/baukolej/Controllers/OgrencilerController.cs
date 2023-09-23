using baukolej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace baukolej.Controllers
{
    [Authorize(Roles ="A,U")]
    public class OgrencilerController : Controller
    {
        bauKolejEntities1 db=new bauKolejEntities1();
        // GET: Ogrenciler
        public ActionResult Index()
        {
            //var result=db.Ogrenciler.ToList();
            var result=db.Ogrenciler.Include(n => n.Okul).ToList();
            return View(result);
        }

        public ActionResult Yeni()
        {
            List<SelectListItem> datalar =(from x in db.Okul.ToList() 
            select new SelectListItem
            {
                Text=x.Adi,
                Value=x.okulNo.ToString(),
            }).ToList();
            ViewBag.datalar = datalar;
            //contreller den veri viev e veri aktarmak için kullanılır.
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