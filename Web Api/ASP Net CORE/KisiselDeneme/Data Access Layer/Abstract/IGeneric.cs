using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Abstract
{
    public interface IGeneric<T> where T : class
    {
        void Update(T t);
        void Add(T t);
        void Remove(T t);
        List<T> GetAll();
        T GetById (int id);
    }
}
