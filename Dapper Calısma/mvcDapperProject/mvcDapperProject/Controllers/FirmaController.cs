using mvcDapperProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace mvcDapperProject.Controllers
{
    public class FirmaController : Controller
    {
        // GET: Firma
        public ActionResult Index()
        {
            return View(DP.Listeleme<FirmaModel>("FirmaVievAll"));
        }
        public ActionResult EY(int id=0)
        {
            if (id==0) //ekleme sayfası yüklenir
            {
                return View();
            }
            else //id ye göre günceleme ekranı gelir.
            {
                DynamicParameters param= new DynamicParameters();
                param.Add("@FirmaNo", id); //id yi alma
                return View(DP.Listeleme<FirmaModel>("FirmaVievByNo",param).FirstOrDefault<FirmaModel>()); //güncelleme yapma
            }
        }
        [HttpPost]
        public ActionResult EY(FirmaModel firma)//post kodları verileri buradan SQL e geri gönderiyoruz.
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("FirmaNo",firma.FirmaNo); //düzenlemede oldugu için FirmaNo yu de ekledik
            param.Add("FirmaAd", firma.FirmaAd);
            param.Add("FirmaCiro", firma.FirmaCiro);
            param.Add("Adres", firma.Adres);
            param.Add("Tel", firma.Tel);

            DP.ExecuteReturn("FirmaEY", param);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id=0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("FirmaNo", id);
            DP.ExecuteReturn("FirmaDelete", param);
            return RedirectToAction("Index");
        }
     }
}