﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;
		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}
		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{

			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWithKategory()
		{
			return _blogDal.GetListWithKategory(); 
		}

		public Blog GetByID(int id)
		{
			return _blogDal.GetByID(id);
		}
		public List<Blog> GetBlogById(int id)
		{
			return _blogDal.GetListAll(x => x.BlogId == id);
		}

		public List<Blog> GetList()
		{
		 return	_blogDal.GetListAll();
		}
	}
}
