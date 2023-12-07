﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using odev_coreAjaxProject.Data;
using odev_coreAjaxProject.Models.Account;
using System.Security.Claims;

namespace odev_coreAjaxProject.Controllers
{
    public class AccountController : Controller
    {
        public readonly ApplicationDbContext context;
        public AccountController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                var data = context.Users.Where(e => e.kAd == user.kAd).SingleOrDefault();
                if (data != null)
                {
                    bool isValid = (data.kAd == user.kAd && data.kSifre == user.kSifre);
                    if (isValid)
                    {
                        var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, user.kAd) }, CookieAuthenticationDefaults.AuthenticationScheme);
                        var prinp = new ClaimsPrincipal(identity);

                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, prinp);
                        HttpContext.Session.SetString("UserName", user.kAd);
                        return RedirectToAction("Index", "Yazar");
                    }
                    else
                    {
                        TempData["errorpsw"] = "Hatalı Şifre";
                        return View(user);
                    }
                }
                else
                {
                    TempData["errorUsername"] = "Hatalı Şifre";
                    return View(user);
                }
            }
            else
            {
                return View();
            }
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var storedCookies = Request.Cookies.Keys;
            foreach (var key in storedCookies)
            {
                Response.Cookies.Delete(key);
            }
            return RedirectToAction("Login", "Account");
        }
        public IActionResult SingUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SingUp(User user)
        {
            if (ModelState.IsValid)
            {
                var data = new User()
                {
                    kAd = user.kAd,
                    kSifre = user.kSifre
                };
                context.Users.Add(data);
                context.SaveChanges();
                TempData["successMessage"] = "başarılı";
                return RedirectToAction("Login");
            }
            else
            {
                TempData["errorMessage"] = "Başarısız";
                return View(user);
            }
        }
    }
}

