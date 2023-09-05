using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class kislikAyakkabi:ayakkabi
    {
        public string uzunluk;
        public string tur;

        public void kislikVerial()
        {
            Console.WriteLine("Boyunu gir: ");
            uzunluk=Console.ReadLine();
            Console.WriteLine("Ayakkabı türünü gir: ");
            tur = Console.ReadLine();
        }
        public void kislikYazir()
        {
            
            VeriAl();
            kislikVerial();
            Yazdır();
            Console.WriteLine("Ayakkabı boyu: " + uzunluk);
            Console.WriteLine("Ayakkabı türü: " + tur);
        }
    }
}
