using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using user_admin.Models;

namespace user_admin.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        Model1Container db= new Model1Container();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(calisan calisan)
        {
            var result = db.calisanSet.FirstOrDefault(x => x.calisanAdSoyad == calisan.calisanAdSoyad && x.calisanTel == calisan.calisanTel);

            if (result != null)
            {
                FormsAuthentication.SetAuthCookie(result.calisanAdSoyad, true);
                return RedirectToAction("Index","Calisan");
            }
            else
            {
                ViewBag.mesaj = "Kullanıcı adı ve ya Şifre yalnış";
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}