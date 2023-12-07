using BusinessLayer.Concreate;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace CoreDemo.ViewComponents.Comment
{
	public class CommentListByBlog:ViewComponent
	{
		CommentManager cm = new CommentManager(new EfCommentRepostory());

		public IViewComponentResult Invoke(int id)
		{			
			var values = cm.GetList(id);
			return View(values);
		}
	}
}
