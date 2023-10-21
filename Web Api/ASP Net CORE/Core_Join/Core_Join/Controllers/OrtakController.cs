using Core_Join.Models;
using Core_Join.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Join.Controllers
{
	public class OrtakController : Controller
	{
		public readonly AppDbContext context;

		public OrtakController(AppDbContext context)
		{
			this.context = context;
		}

		public IActionResult Index2()
		{
			return View();

		}

		public IActionResult Index()
		{
			//using merge model
			elemanDepListModel listModel = new elemanDepListModel();
			var elemmandata = context.Elemens.ToList();
			var depdata = context.Departmans.ToList();
			listModel.Eleman = elemmandata;
			listModel.Departmen = depdata;
			return View(listModel);
		}
		public IActionResult JoinIndex1()
		{
			var data = (from e in context.Elemens
						join d in context.Departmans on e.DepartmanID equals d.DepartmanID
						select new elemanDepViewModel
						{
							ElemanID = e.ElemanID,
							Ad = e.Ad,
							Soyad = e.Soyad,
							Adres = e.Adres,
							DepartmanID = d.DepartmanID,
							Code = d.Code,
							Name = d.Name

						}).ToList();
			return View(data);
		}
	}
}
