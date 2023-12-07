using BusinessLayer.Concreate;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.ViewComponents.Category
{
	public class CategoryList:ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EfKategoryRepostory());

		public IViewComponentResult Invoke()
		{
			var valus = cm.GetList();
			return View(valus);
		}
	}
}
