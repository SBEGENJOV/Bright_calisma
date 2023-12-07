using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
	public class CommentList:ViewComponent //view component kullanabilmek için kalıtım aldım
	{
		public IViewComponentResult Invoke()
		{
			var commentValues = new List<UserComment>
			{
				new UserComment
				{
					ID= 1,
					UserName="Seyit"
				},
				new UserComment
				{
					ID= 2,
					UserName="Tuba"
				},
				new UserComment
				{
					ID= 3,
					UserName="Furkan"
				}
			};
			return View(commentValues);
		}
	}
}
