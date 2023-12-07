using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calismaORMData.Repository.IRepository
{
    public interface IUnityOfWork:IDisposable
    {
        //IDisposable ne işe yarar 
        //Aslında biz referans degerli değişkenlerimizi nesnlerimizin using ile bellekten temizliyorduk. Bunu yapan interface ise  IDisposable bu görevi verir.
        IKategoriRepository Kategori { get; }
        IUrunlerRepository Urunler { get; }
        void Save();
    }
}
