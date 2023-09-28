using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApplication1.Models;
using System.Web.Security;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = "Kütüphaneci,Güvenlikçi")]
    public class MasaController : Controller
    {
        // GET: Masa
        kutuphaneEntities db=new kutuphaneEntities();
        public ActionResult Index( string x)
        {
            var search = from m in db.Calisma select m;
            if (x != null)
            {
                search = search.Where(m => m.masaAd.Contains(x));
            }
            db.Calisma.Include(n => n.Kutuphane).ToList();
            return View(search);
        }

        public ActionResult Yeni()
        {
            List<SelectListItem> list = (from x in db.Kutuphane select new SelectListItem
            {
                Text=x.kutuphaneAdi,
                Value=x.kutuphaneID.ToString()
            }).ToList();
            ViewBag.kut=list;
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Calisma calisma)
        {
            db.Calisma.Add(calisma);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            List<SelectListItem> liste=(from x in db.Kutuphane select new SelectListItem
            {
                Text=x.kutuphaneAdi,
                Value=x.kutuphaneID.ToString()
            }).ToList();
            ViewBag.kut=liste;
            return View(db.Calisma.Find(id));
        }
        [HttpPost]
        public ActionResult Edit (int id,Calisma calisma)
        {

            db.Entry(calisma).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(db.Calisma.Find(id));
        }
        [HttpPost]
        public ActionResult Delete(int id,Calisma calisma)
        {
            db.Calisma.Remove(db.Calisma.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}