using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("Sayıyı Girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 1)
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır.", sayi);
            }
            else
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir.", sayi);
            }
            Console.ReadLine();
        }
    }
}
