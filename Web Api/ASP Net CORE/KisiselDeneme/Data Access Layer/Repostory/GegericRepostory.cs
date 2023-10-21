using Data_Access_Layer.Abstract;
using Data_Access_Layer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repostory
{
    public class GegericRepostory<T> : IGeneric<T> where T : class
    {
        Context c=new Context();
        public void Add(T t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
          return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public void Remove(T t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}
