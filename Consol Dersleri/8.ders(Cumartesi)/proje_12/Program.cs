using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int say,sayac=0,top=0;
            do
            {
                sayac++;
                say = rnd.Next(1, 101);
                Console.WriteLine(sayac+".Üretilen sayı: " + say);
                top += say;
            } while (say != 50);
            Console.WriteLine("Toplam üretilen sayı: " + sayac);
            Console.WriteLine("Toplam üretilen sayıların toplamı: " + top);
            Console.ReadLine();
        }
    }
}
