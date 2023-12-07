using coreAjaxProject.Data;
using coreAjaxProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreAjaxProject.Controllers
{
    public class EmployeControler : Controller
    {
        public readonly ApplicationDbContext context; 
        public EmployeControler(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult EmployeList()
        {
            var data = context.Employes.ToList();
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult AddEmploye(employe employe)
        {
            var emp = new employe()
            {
                Name = employe.Name,
                City = employe.City,
                State = employe.State,
                Salary = employe.Salary
            };
            context.Employes.Add(emp);
            context.SaveChanges();
            return new JsonResult("Ekleme İşlemi Başarılı");
        }
        public JsonResult Edit(int id)
        {
            var data = context.Employes.Where(e => e.ID == id).SingleOrDefault();
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult Update(employe employe)
        {
            context.Employes.Update(employe);
            context.SaveChanges();
            return new JsonResult("Güncellem İşlemi Başarılı");
        }

        public JsonResult Delete(int id)
        {
            var data = context.Employes.Where(e => e.ID == id).SingleOrDefault();
            context.Employes.Remove(data);
            context.SaveChanges();
            return new JsonResult("Data Deleted");
        }
    }
}
