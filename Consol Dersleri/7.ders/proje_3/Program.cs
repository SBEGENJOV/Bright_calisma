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
            int carp;
            Console.WriteLine("Lütfen son çarpılacak sayı girin: ");
            int say=int.Parse(Console.ReadLine());
            for(int i = 1; i <= say; i++)
            {
                carp = say * i;
                Console.WriteLine(i + " x "+say+" = " + carp);
            }
            Console.ReadLine();
        }
    }
}
