using CoreData.Data;
using CoreModel.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreKatmanUI.Controllers
{
    public class RaporController : Controller
    {
        public readonly ApplicationDbContext Context;
        public RaporController(ApplicationDbContext context)
        {
            this.Context = context;
        }
        public IActionResult Index()
        {
            var result = (from x in Context.Derslers join o in Context.Ogretmenlers on x.DersID equals o.DersID select new ListView
            {
                AdSoyad=o.AdSoyad,
                Maas=o.Maas,
                DersID=o.DersID,
                DersAd=x.DersAd
            }).ToList();


            return View(result);
        }
    }
}
