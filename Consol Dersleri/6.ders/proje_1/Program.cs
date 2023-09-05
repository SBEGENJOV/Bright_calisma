using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int top = 0, tek=0;
            
            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine(i+".Lütfen sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi%2==0)
                {
                    top += sayi;
                }
                else
                {
                    Console.WriteLine("gireilen sayı çitf değil o yüzden toplanmayacak");
                    tek++;
                }
            }
            Console.WriteLine("Çİft Sayıların toplamı: " + top);
            Console.WriteLine("Tek sayıların adeti: " + tek);
            Console.ReadLine();
        }
    }
}
