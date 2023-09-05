using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EKSİK
            double kupon = 0;
            Console.WriteLine("Lütfen ürün sayısını girimn: ");
            int uSayi=int.Parse(Console.ReadLine());
            for(int i=0; i<uSayi; i++)
            {
                Console.WriteLine("Ürün için fiyat girin: ");
                int uFiyat = int.Parse(Console.ReadLine());
                double kindirim = 0;
                for (int j=1; j<=3; j++)
                {
                    Console.WriteLine(j+".Kupon için indirimi girin: ");
                    kupon=double.Parse(Console.ReadLine());
                    kindirim += kupon;
                }
            }
        }
    }
}
