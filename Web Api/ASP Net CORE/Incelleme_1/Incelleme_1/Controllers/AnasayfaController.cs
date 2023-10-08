using Incelleme_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Incelleme_1.Controllers
{
    public class AnasayfaController : Controller
    {
        public IActionResult Index()
        {
            Hizmetler hizmet = new Hizmetler();
            hizmet.HizmetNo = 10;
            hizmet.HizmetAdi = "Messi";
            hizmet.Tutar = 100;

            Personel personel = new Personel();
            personel.No = 7;
            personel.AdSoyad = "Seyit";
            personel.Yas = 25;

            var ortakAlan = (hizmet, personel);

            return View(ortakAlan);
        }


        public IActionResult About()
        {
            return View();
        }
    }
}
