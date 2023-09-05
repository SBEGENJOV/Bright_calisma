using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ders
{
    internal class ErkekCocukGiyim:ErkekGiyim
    {
        public int yas;
        public string kumasTuru;


        public void Cocukyazdir()
        {
            veriAl();
            Yazdır();
            yas = 10;
            kumasTuru = "Pamuk";
            Console.WriteLine("Yas: " + yas);
            Console.WriteLine("Kumaş türür: "+kumasTuru);
            Console.WriteLine("Aksesuar: " + aksesuar);
            Console.WriteLine("Son ödemeniz gereken tutar: " + Zam(fiyat, marka));
        }
    }
}
