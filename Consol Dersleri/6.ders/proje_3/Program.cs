using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ucsay = 0, ucdsay = 0;
            for(int i = 1; i <=5; i++)
            {
                Console.WriteLine("Lütfen sayı giriniz: ");
                string say =Console.ReadLine();
                if (say.Length==3)
                {
                    ucsay++;
                }
                else
                {
                    ucdsay=ucdsay+(Convert.ToInt32(say));
                }
            }
            Console.WriteLine("3 basamaklı sayıların adeti: " + ucsay);
            Console.WriteLine("3 basamaklı olmayanların toplamı: " + ucdsay);
            Console.ReadLine();
        }
    }
}
