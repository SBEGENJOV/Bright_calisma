using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class hediye : Iveri,Iozellik
    {
       

        public void kampanya()
        {
           // throw new NotImplementedException();
        }

       public void add()
        {
            Console.WriteLine("Veri eklendi");
        }

        public void delete()
        {
            Console.WriteLine("Veri silindi");
        }

        public void filtre()
        {
            Console.WriteLine("Veri filtrelendi");
        }

        public void update()
        {
            Console.WriteLine("Veri güncellerndi");
        }

        public int zam(int fiyat)
        {
            return fiyat;
        }
    }
}
