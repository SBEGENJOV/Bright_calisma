using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NameSurname = "Seyit";
            int Number, Number2;
            Number = 100; Number2 = 200;

            Console.WriteLine("Sayı degerim: " + (Number*10));
            Console.WriteLine("Ad Soyad: " + NameSurname);
            Console.ReadLine();//ekranın sabit kalmasını sağlar.
        }
    }
}
