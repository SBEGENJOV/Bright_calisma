using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
	public class EfBlogRepostory : GenericRepository<Blog>, IBlogDal
	{
		public List<Blog> GetListWithKategory()
		{
			using(var c =new Context())
			{
				return c.Blogs.Include(x=>x.Kategori).ToList();
			}
			 
		}
	}
}
