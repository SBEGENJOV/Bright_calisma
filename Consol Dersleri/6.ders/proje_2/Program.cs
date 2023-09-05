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
            //int Çtop = 0;
            //for (int i = 75; i <= 300; i += 2)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Çtop++;
            //    }
            //}
            //Console.WriteLine("Toplam: " + Çtop);
            //Console.ReadLine();

            int fak = 1;
            Console.WriteLine("Lütfen sayı giriniz: ");
            int say = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= say; i++)
            {
                fak *= i;
            }
            Console.WriteLine("Sonuç: " + fak);
            Console.ReadLine();


        }
    }
}
