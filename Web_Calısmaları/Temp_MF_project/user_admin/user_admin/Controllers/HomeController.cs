using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace user_admin.Models
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult s404()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult blog()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        public ActionResult feature()
        {
            return View();
        }
        public ActionResult product()
        {
            return View();
        }
        public ActionResult store()
        {
            return View();
        }
        public ActionResult testimonial()
        {
            return View();
        }
    }
}