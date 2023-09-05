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
            double kom = 0, tkom = 0; ;
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine(i+".Satılan malın fiyatını girin: ");
                double fiy = Convert.ToDouble(Console.ReadLine());
                if (fiy >= 0 ||fiy<=50)
                {
                    kom += fiy * 3 / 100;
                    Console.WriteLine("Uygulnacak komisyon: " + kom);
                    tkom += kom;
                }
                else if (fiy>50)
                {
                    kom += fiy * 2 / 100;
                    Console.WriteLine("Uygulnacak komisyon: " + kom);
                    tkom += kom;
                }
            }
            Console.WriteLine("Toplam uygulanan komisyon tutarı: " + tkom);
            Console.ReadLine();
        }
    }
}
