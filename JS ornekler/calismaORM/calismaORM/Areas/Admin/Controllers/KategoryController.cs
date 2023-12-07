using calismaORMData.Repository.IRepository;
using calismaORMModel;
using Microsoft.AspNetCore.Mvc;

namespace calismaORM.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KategoryController : Controller
    {
        private readonly IUnityOfWork _unityOfWork;
        public KategoryController(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Kategori> kategoriList = _unityOfWork.Kategori.GetAll();
            return View(kategoriList);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Kategori kategori)
        {
            _unityOfWork.Kategori.Add(kategori);
            _unityOfWork.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id==null || id<=0)
            {
                return NotFound();
            }
            var kategori= _unityOfWork.Kategori.GetFirstOrDefault(k => k.Id==id);
            return View(kategori);
        }
        [HttpPost]
        public IActionResult Edit(Kategori kategori)
        {
            _unityOfWork.Kategori.Update(kategori);
            _unityOfWork.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var kategori = _unityOfWork.Kategori.GetFirstOrDefault(k => k.Id == id);
            _unityOfWork.Kategori.Remove(kategori);
            _unityOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
