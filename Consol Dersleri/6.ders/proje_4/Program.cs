using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yedi = 0,top=0;
            Console.WriteLine("Lütfen sayı giriniz: ");
            int say=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= say; i++)
            {
                if (i % 7 == 0)
                {
                    yedi++;
                }
                else
                {
                    top += i;
                }
            }
            Console.WriteLine("7 ye bölünenlerin adeti: " + yedi);
            Console.WriteLine("7 ye bölünmyenlerin toplamı: " + top);
            Console.ReadLine();
        }
    }
}
