using Microsoft.AspNetCore.Mvc;
using odev_coreAjaxProject.Data;
using odev_coreAjaxProject.Models;

namespace odev_coreAjaxProject.Controllers
{
    public class KitapController : Controller
    {
        public readonly ApplicationDbContext context;
        public KitapController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult KitapList()
        {
            var data = context.Kitaps.ToList();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult Add(Kitap kitap)
        {
            var kit = new Kitap()
            {
                KitapAd = kitap.KitapAd,
                KitapYazar = kitap.KitapYazar,
                KitapYil = kitap.KitapYil,
                KitapSayfa = kitap.KitapSayfa
            };
            context.Kitaps.Add(kit);
            context.SaveChanges();
            return new JsonResult("Ekleme İşlemi Başarılı");
        }

        [HttpGet]
        public JsonResult Edit(int id)
        {
            var data = context.Kitaps.Where(e => e.KitapID == id).SingleOrDefault();
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult Edit(Kitap kitap)
        {
            context.Kitaps.Update(kitap);
            context.SaveChanges();
            return new JsonResult("İşlem Başarılı");
        }
        public JsonResult Delete(int id)
        {
            var data = context.Kitaps.Where(w => w.KitapID == id).SingleOrDefault();
            context.Remove(data);
            context.SaveChanges();
            return new JsonResult("İşlem Başarılı");
        }
    }
}
