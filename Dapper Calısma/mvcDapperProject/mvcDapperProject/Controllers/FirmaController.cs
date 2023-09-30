using mvcDapperProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcDapperProject.Controllers
{
    public class FirmaController : Controller
    {
        // GET: Firma
        public ActionResult Index()
        {
            return View(DP.Listeleme<FirmaModel>("FirmaVievAll"));
        }
    }
}