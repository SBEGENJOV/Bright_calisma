using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcProject.Models;
using System.Net.Http;
using System.Net.Http.Handlers;
using System.Reflection;

namespace mvcProject.Controllers
{
    public class DavaController : Controller
    {
        // GET: Dava
        public ActionResult Index()
        {
            IEnumerable<mvcDavaModel> responseList;//modal ile controllerden gelen verileri eşleştirir
            HttpResponseMessage response = GlobalVariables.webapiclient.GetAsync("Davalars").Result;//api deki controllere baglan ve verileri çek.
            responseList = response.Content.ReadAsAsync<IEnumerable<mvcDavaModel>>().Result;//çektigin verileri oku ve liste halinde tut

            return View(responseList);//liste halindeki verlieri viev aktrar
        }

        public ActionResult EY(int id=0)
        {
            if (id == 0)
            {
                return View(new mvcDavaModel());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.webapiclient.GetAsync("Davalars/"+id.ToString()).Result;//Veriyi id'ye göre getirecek.
                return View (response.Content.ReadAsAsync<mvcDavaModel>().Result);
            }
        }
        [HttpPost]
        public ActionResult EY(mvcDavaModel model)
        {
            if (model.DavaNo==0)
            {
                //post
                HttpResponseMessage response = GlobalVariables.webapiclient.PostAsJsonAsync("Davalars", model).Result;
            }
            else
            {
                //put: api de güncelleme yapmaya yarar.
                HttpResponseMessage response = GlobalVariables.webapiclient.PutAsJsonAsync("Davalars/"+model.DavaNo,model).Result;
            }
            return RedirectToAction("Index");

        }
        public ActionResult Delete (int id)
        {
            HttpResponseMessage response = GlobalVariables.webapiclient.DeleteAsync("Davalars/" +id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}