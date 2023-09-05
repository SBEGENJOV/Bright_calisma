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
            int top = 0;
            int bes = 0;
            
            for (int i = 1; i <=7; i++)
            {
                Console.WriteLine("Sayı giriniz: ");
                
                int say = Convert.ToInt32(Console.ReadLine());
                top += say;
                if (i == 5)
                {
                    bes += say;
                }
            }
            Console.WriteLine("Sayıların toplamı: " + top);
            Console.WriteLine("Sayıların toplamının 5.sayıya böleni: " + (top/bes));
            Console.ReadLine();
        }
    }
}
