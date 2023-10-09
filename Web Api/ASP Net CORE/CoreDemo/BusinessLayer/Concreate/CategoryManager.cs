using BusinessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
   public class CategoryManager : IKategorySevice
    {
        EfKategoryRepostory efKategoryRepostory;
        public CategoryManager()
        {
            efKategoryRepostory = new EfKategoryRepostory();
        }
        public Kategori GetByID(int id)
        {
           return efKategoryRepostory.GetByID(id);
        }

        public List<Kategori> GetList()
        {
            return efKategoryRepostory.GetListAll();
        }

        public void KategoryAdd(Kategori kategori)
        {
            efKategoryRepostory.Insert(kategori);
        }

        public void KategoryDelete(Kategori kategori)
        {
            efKategoryRepostory.Delete(kategori);
        }

        public void KategoryUpdate(Kategori kategori)
        {
            efKategoryRepostory.Update(kategori);
        }
    }
}
