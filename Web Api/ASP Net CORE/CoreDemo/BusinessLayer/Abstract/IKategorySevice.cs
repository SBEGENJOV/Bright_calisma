using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IKategorySevice
    {
        void KategoryAdd(Kategori kategori);
        void KategoryDelete(Kategori kategori);
        void KategoryUpdate(Kategori kategori);
       List<Kategori> GetList();
       Kategori GetByID(int id);
    }
}
