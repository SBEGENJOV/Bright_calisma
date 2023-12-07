using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
		void CommentAdd(Kategori kategori);
		//void KategoryDelete(Kategori kategori);
		//void KategoryUpdate(Kategori kategori);
		List<Comment> GetList(int id);
		//Comment GetByID(int id);
	}
}
