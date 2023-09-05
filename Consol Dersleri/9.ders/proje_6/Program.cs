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
            int[] fiyat = new int[3];
            int zam = 0;
            for (int i = 0; i < fiyat.Length; i++) 
            {
                Console.WriteLine(i+1+".Ürün fiyatını girin: ");
                fiyat[i] = int.Parse(Console.ReadLine());
                if (fiyat[i]>9 && fiyat[i]<=99)
                {
                    zam += fiyat[i]* 20 / 100;
                    
                }
                else if (fiyat[i]>99 && fiyat[i] <= 999)
                {
                    zam += fiyat[i] * 50 / 100;
                    
                }
            }
            Console.WriteLine("Toplam yapılan zam miktarı: " + zam);
            Console.ReadLine();
        }
    }
}
