using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using model_first.Models;

namespace model_first.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        Model1Container db=new Model1Container();
        public ActionResult Index()
        {
            var result= db.PersonelSet.ToList();
            return View(result);
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Personel personel)
        {
            try
            {
                using(Model1Container con=new Model1Container())
                {
                    con.PersonelSet.Add(personel);
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
            var result = db.PersonelSet.Where(x => x.PersonelNo == id).FirstOrDefault();
            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(int id,Personel personel)
        {
            try
            {
                db.Entry(personel).State = System.Data.Entity.EntityState.Modified;
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
            var result = db.PersonelSet.Where(x => x.PersonelNo == id).FirstOrDefault();
            return View(result);
        }
        [HttpPost]
        public ActionResult Delete(int id,Personel personel)
        {
            personel=db.PersonelSet.Where(x=>x.PersonelNo==id).FirstOrDefault();
            db.PersonelSet.Remove(personel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}