using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {
        // GET: Security
        kutuphaneEntities db=new kutuphaneEntities();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Calisanlar calisanlar)
        {
            var result=db.Calisanlar.FirstOrDefault(x=>x.calisanAdSoyad==calisanlar.calisanAdSoyad && x.calisanSifre==calisanlar.calisanSifre);
            if (result!=null)
            {
                FormsAuthentication.SetAuthCookie(result.calisanAdSoyad, false);
               return RedirectToAction("Index","Masa");
            }
            else 
            {
                ViewBag.mesaj = "Kullanıcı bulunamadı";
                return View(); 
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}