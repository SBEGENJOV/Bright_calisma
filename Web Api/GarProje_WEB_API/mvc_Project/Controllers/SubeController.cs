using mvc_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace mvc_Project.Controllers
{
    public class SubeController : Controller
    {
        // GET: Sube
        public ActionResult Index()
        {
            IEnumerable<mvcSubeModel> responseList;//modal ile controllerden gelen verileri eşleştirir
            HttpResponseMessage response = GlobalVariables.webapiclient.GetAsync("Subes").Result;//api deki controllere baglan ve verileri çek.
            responseList = response.Content.ReadAsAsync<IEnumerable<mvcSubeModel>>().Result;//çektigin verileri oku ve liste halinde tut

            return View(responseList);//liste halindeki verlieri viev aktrar
        }
        public ActionResult EY(int id = 0)
        {
            if (id == 0)
            {
                return View(new mvcSubeModel());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.webapiclient.GetAsync("Subes/" + id.ToString()).Result;//Veriyi id'ye göre getirecek.
                return View(response.Content.ReadAsAsync<mvcSubeModel>().Result);
            }
        }

        [HttpPost]
        public ActionResult EY(mvcSubeModel model)
        {
            if (model.SubeNo == 0)
            {
                //post
                HttpResponseMessage response = GlobalVariables.webapiclient.PostAsJsonAsync("Subes", model).Result;
            }
            else
            {
                //put: api de güncelleme yapmaya yarar.
                HttpResponseMessage response = GlobalVariables.webapiclient.PutAsJsonAsync("Subes/" + model.SubeNo, model).Result;
            }
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.webapiclient.DeleteAsync("Subes/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}