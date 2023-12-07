using Microsoft.AspNetCore.Mvc;
using odev_coreAjaxProject.Data;
using odev_coreAjaxProject.Models;

namespace odev_coreAjaxProject.Controllers
{
    public class YazarController : Controller
    {
        public readonly ApplicationDbContext context;
        public YazarController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult YazarList()
        {
            var data=context.Yazars.ToList();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult Add(Yazar yazar)
        {
            var yaz = new Yazar()
            {
                YazarAdSoyad = yazar.YazarAdSoyad,
                YazarMemleket = yazar.YazarMemleket,
                YazarYas = yazar.YazarYas,
                YazarKitapYaz = yazar.YazarKitapYaz
            };
            context.Yazars.Add(yaz);
            context.SaveChanges();
            return new JsonResult("Ekleme İşlemi Başarılı");
        }

        [HttpGet]
        public JsonResult Edit(int id)
        {
            var data = context.Yazars.Where(e => e.YazarID == id).SingleOrDefault();
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult Edit(Yazar yazar)
        {
            context.Yazars.Update(yazar);
            context.SaveChanges();
            return new JsonResult("İşlem Başarılı");
        }
        public JsonResult Delete(int id)
        {
            var data=context.Yazars.Where(w=>w.YazarID==id).SingleOrDefault();
            context.Remove(data);
            context.SaveChanges();
            return new JsonResult("İşlem Başarılı");
        }
    }
}
