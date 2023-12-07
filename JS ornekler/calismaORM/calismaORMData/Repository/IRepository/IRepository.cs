using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calismaORMData.Repository.IRepository
{
    
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);

        //expression system.linq.expression dll altında bulunur çok satırlı ifadelerin function tarafından karsılanmasını sağlar buradaki func aslında geriye bir deger döndürücegi anlamına gelir.
        T GetFirstOrDefault(Expression<Func<T, bool>> filter,string? includeProperties=null);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> ? filter=null, string? includeProperties = null);
        void RemoveRange(IEnumerable<T> entities);//Diğer metotdaki fk olan alanları silmek için kullanıcaz.

    }
}
