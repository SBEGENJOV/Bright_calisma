using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    public class OgrenciiController : Controller
    {
        kutuphaneEntities db= new kutuphaneEntities();
        public ActionResult Index()
        {
            var result=db.Ogrenciler.Include(x => x.Kutuphane).Include(x => x.Calisma).ToList();
            return View(result);
        }

        public ActionResult Yeni()
        {
            List<SelectListItem> liste = (from x in db.Kutuphane
                                         select new SelectListItem
                                         {
                                             Text = x.kutuphaneAdi,
                                             Value = x.kutuphaneID.ToString()
                                         }).ToList();

            List<SelectListItem> liste1 = (from x in db.Calisma
                                          select new SelectListItem
                                          {
                                              Text = x.masaAd,
                                              Value = x.masaID.ToString()
                                          }).ToList();
            ViewBag.kutup = liste;
            ViewBag.masa=liste1;
            return View();
        }
        [HttpPost]

        public ActionResult Yeni(Ogrenciler ogrenciler)
        {
            db.Ogrenciler.Add(ogrenciler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}