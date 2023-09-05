using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_12
{
    internal class ElektronikEsya
    {
        public string marka;
        public string model;
        public int fiyat;
        public string mensei;
        public int yil;

        public int kdv(int fiyat) 
        {
            fiyat += 100;
            return fiyat; 
        }
        public void hediye()
        {
            Console.WriteLine("Tebrikler hediye çeki kazandın");
        }
    }
}
