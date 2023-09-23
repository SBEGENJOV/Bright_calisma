using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baukolej.Models;
using System.Web.Security; //bu kütüphane ile authentitaciton forms ayarlıycaz

namespace baukolej.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {
        // GET: Security
        bauKolejEntities1 db=new bauKolejEntities1();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Kullanicilar kullanicilar)
        {
            var result= db.Kullanicilar.FirstOrDefault(x =>x.kullaniciAdi==kullanicilar.kullaniciAdi && x.sifre==kullanicilar.sifre);
            if (result != null)
            {
                FormsAuthentication.SetAuthCookie(result.kullaniciAdi, true);
                return RedirectToAction("Index","Ogrenciler");
            }
            else
            {
                ViewBag.mesaj = "Kullanıcı bulunamadı";
                return View();
            }
        }
        public ActionResult LoginOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}