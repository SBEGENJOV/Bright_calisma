using calismaORMData;
using calismaORMData.Repository.IRepository;
using calismaORMModel.viewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace calismaORM.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UrunlerController : Controller
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UrunlerController(IUnityOfWork unityOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unityOfWork = unityOfWork;
            _webHostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            var urunList = _unityOfWork.Urunler.GetAll();
            return View(urunList);
        }
        public IActionResult Crup(int? id = 0)
        {
            UrunlerVM urunlerVM = new()
            {
                Urunler = new(),
                KategoriList = _unityOfWork.Kategori.GetAll().Select(k => new SelectListItem
                {
                    Text = k.KategoriAdi,
                    Value = k.Id.ToString()
                })
            }; 
            //combox u çalıştıran alan
            if (id == null || id <= 0)
            {
                return View(urunlerVM);
            }
            urunlerVM.Urunler = _unityOfWork.Urunler.GetFirstOrDefault(x => x.Id == id);
            if (id==null || id<=0)
            {
                return View(urunlerVM);
            }
            return View(urunlerVM);
        }
        [HttpPost]
        public IActionResult Crup(UrunlerVM urunlerVM,IFormFile file)
        {
            string wwwRothPath = _webHostEnvironment.WebRootPath;
            if (file!=null)
            {
                string fileName=Guid.NewGuid().ToString();
                var uploadRoot=Path.Combine(wwwRothPath, @"img\urunlers");
                var extension=Path.GetExtension(file.FileName);
                if (urunlerVM.Urunler.Resim !=null)
                {
                    var oldpicPath = Path.Combine(wwwRothPath, urunlerVM.Urunler.Resim);
                    if (System.IO.File.Exists(oldpicPath))
                    {
                        System.IO.File.Delete(oldpicPath);
                    }
                }
                using (var fileStream = new FileStream(Path.Combine(uploadRoot, fileName + extension), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                urunlerVM.Urunler.Resim = @"\img\urunlers\" + fileName + extension;
            }
            if (urunlerVM.Urunler.Id<=0)
            {
                _unityOfWork.Urunler.Add(urunlerVM.Urunler);
            }
            else
            {
                _unityOfWork.Urunler.Update(urunlerVM.Urunler);
            }
            _unityOfWork.Save();
            return RedirectToAction("Index");
        }
        public IActionResult Delete (int? id)
        {
            if (id==null || id<=0)
            {
                return NotFound();
            }
            var product=_unityOfWork.Urunler.GetFirstOrDefault(x=>x.Id==id);
            _unityOfWork.Urunler.Remove(product);
            _unityOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
