using Microsoft.AspNetCore.Mvc;
using odev_coreAjaxProject.Data;
using odev_coreAjaxProject.Models;

namespace odev_coreAjaxProject.Controllers
{
    public class KutuphaneController : Controller
    {
        public readonly ApplicationDbContext context;
        public KutuphaneController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult KutuphaneList()
        {
            var data = context.Kutuphanes.ToList();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult Add(Kutuphane kutuphane)
        {
            var kutuphane1 = new Kutuphane()
            {
                KutuphaneAd = kutuphane.KutuphaneAd,
                KutuphaneKonum = kutuphane.KutuphaneKonum,
                KutuphaneMasaSay = kutuphane.KutuphaneMasaSay,
                KutuphaneYonetici = kutuphane.KutuphaneYonetici
            };
            context.Kutuphanes.Add(kutuphane1);
            context.SaveChanges();
            return new JsonResult("Ekleme İşlemi Başarılı");
        }

        [HttpGet]
        public JsonResult Edit(int id)
        {
            var data = context.Kutuphanes.Where(e => e.KutuphaneID == id).SingleOrDefault();
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult Edit(Kutuphane kutuphane)
        {
            context.Kutuphanes.Update(kutuphane);
            context.SaveChanges();
            return new JsonResult("İşlem Başarılı");
        }
        public JsonResult Delete(int id)
        {
            var data = context.Kutuphanes.Where(w => w.KutuphaneID == id).SingleOrDefault();
            context.Remove(data);
            context.SaveChanges();
            return new JsonResult("İşlem Başarılı");
        }
    }
}
