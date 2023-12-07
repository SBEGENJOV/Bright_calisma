using BusinessLayer.Concreate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm= new WriterManager (new EfWriterRepostory());

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			WriterValidator wv = new WriterValidator ();
            ValidationResult result = wv.Validate(writer);
			if (result.IsValid)
			{
                writer.WriterStatus = true;
                writer.WriterAbout = "Deneme Test";
                wm.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
