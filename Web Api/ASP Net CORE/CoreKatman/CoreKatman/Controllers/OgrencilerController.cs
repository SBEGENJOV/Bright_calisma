using CoreData.Data;
using CoreModel.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKatmanUI.Controllers
{
    public class OgrencilerController : Controller
    {
        public readonly ApplicationDbContext Context;
        public OgrencilerController(ApplicationDbContext context)
        {
            this.Context = context;
        }
        public IActionResult Index()
        {

            return View(Context.Ogrencilers.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Ogrenciler ogrenciler)
        {
            Context.Add(ogrenciler);
            await Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id==0)
            {
             return RedirectToAction("Index");
            }

            var result =await Context.Ogrencilers.FindAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Ogrenciler ogrenciler)
        {
            Context.Update(ogrenciler);
            await Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }

            var result = await Context.Ogrencilers.FindAsync(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Ogrenciler ogrenciler)
        {
            Context.Remove(ogrenciler);
            await Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
