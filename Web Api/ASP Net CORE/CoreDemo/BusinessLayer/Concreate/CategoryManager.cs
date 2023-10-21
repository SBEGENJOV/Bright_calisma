using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
        IKategoryDal _kategoryDal;
       public CategoryManager(IKategoryDal kategoryDal)
        {
            _kategoryDal = kategoryDal;
        }

        public Kategori GetByID(int id)
        {
           return _kategoryDal.GetByID(id);
        }

        public List<Kategori> GetList()
        {
            return _kategoryDal.GetListAll();
        }

        public void KategoryAdd(Kategori kategori)
        {
            _kategoryDal.Insert(kategori);
        }

        public void KategoryDelete(Kategori kategori)
        {
            _kategoryDal.Delete(kategori);
        }

        public void KategoryUpdate(Kategori kategori)
        {
            _kategoryDal.Update(kategori);
        }
    }
}
