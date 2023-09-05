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
            int top=0;
            int say = 0;
            
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i+". Sayı gir: ");
                say =Convert.ToInt32(Console.ReadLine());
                top = top + say;
            }
            Console.WriteLine("Sayıların toplamı: " + top);
            Console.ReadLine();
        }
    }
}
