using mvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace mvcProject.Controllers
{
    public class SubeController : Controller
    {
        // GET: Sube
        public ActionResult Index()
        {
            IEnumerable<mvcSubeModel> responseList;//modal ile controllerden gelen verileri eşleştirir
            HttpResponseMessage response = GlobalVariebles.webapiclient.GetAsync("Subes").Result;//api deki controllere baglan ve verileri çek.
            responseList = response.Content.ReadAsAsync<IEnumerable<mvcSubeModel>>().Result;//çektigin verileri oku ve liste halinde tut

            return View(responseList);//liste halindeki verlieri viev aktrar
        }
    }
}