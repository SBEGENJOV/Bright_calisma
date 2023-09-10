using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace razor_3.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Campus()
        {
            return View();
        }
        public ActionResult Basin()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
    }
}