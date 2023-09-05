using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_metotlar4
{
    internal class Program
    {
        static void bir()
        {
            Console.WriteLine("Parametresiz metot kullanımı");
        }
        static void iki(int top)
        {
            top= top + 10;
            Console.WriteLine("Parametreli metot kullanımı "+top);
        }
        static void uc(int top,int say1)
        {
            top = top + say1;
            Console.WriteLine("2 Parametreli metot kullanımı " + top);
        }
        static void dort(double top, int say1)
        {
            top = top + say1;
            Console.WriteLine("2 Parametreli metot kullanımı " + top);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("iki adlı metot için sayı gir: ");
            Console.WriteLine("uc adlı metot için 1.sayı gir: ");
            int top=int.Parse(Console.ReadLine());
            Console.WriteLine("uc adlı metot için 2.sayı gir: ");
            int say = int.Parse(Console.ReadLine());
            bir();
            iki(top);
            uc(top, say);

            Console.ReadLine();
        }
    }
}
