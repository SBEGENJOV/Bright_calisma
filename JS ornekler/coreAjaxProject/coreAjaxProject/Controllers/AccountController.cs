using coreAjaxProject.Data;
using coreAjaxProject.Models.Account;
using coreAjaxProject.Models.viewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace coreAjaxProject.Controllers
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
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var data = context.Users.Where(e => e.UserName == model.UserName).SingleOrDefault();
                if (data != null)
                {
                    bool isValid = (data.UserName == model.UserName && data.Password == model.ConfirmPassword);
                    if (isValid)
                    {
                        var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.UserName) }, CookieAuthenticationDefaults.AuthenticationScheme);
                        var prinp = new ClaimsPrincipal(identity);

                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, prinp);
                        HttpContext.Session.SetString("UserName", model.UserName);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["errorpsw"] = "Hatalı Şifre";
                        return View(model);
                    }
                }
                else
                {
                    TempData["errorUsername"] = "Hatalı Şifre";
                    return View(model);
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
        public IActionResult SingUp(LoginViewModel modal)
        {
            if (ModelState.IsValid)
            {
                var data = new User()
                {
                    UserName = modal.UserName,
                    Email = modal.Email,
                    Password = modal.ConfirmPassword,
                    Mobile = modal.Mobile,
                    IsActive = modal.IsActive
                };
                context.Users.Add(data);
                context.SaveChanges();
                TempData["successMessage"] = "başarılı";
                return RedirectToAction("Login");
            }
            else
            {
                TempData["errorMessage"] = "Başarısız";
                return View(modal);
            }
        }
    }
}
