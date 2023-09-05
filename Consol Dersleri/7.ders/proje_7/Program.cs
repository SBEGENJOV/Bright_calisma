using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int tnot = 0;
            Console.WriteLine("Kaç öğrenciniz var: ");
            int oSay=int.Parse(Console.ReadLine());
            for(int i = 1; i <= oSay; i++)
            {
                int tnot = 0;
                Console.WriteLine("Kaç not girilecek:");
                int knot=int.Parse(Console.ReadLine());
                Console.WriteLine(i + ".Öğrencinin notunu gir: ");
                for (int j = 1; j <= knot; j++)
                {
                    Console.WriteLine(j + ".Not: ");
                    int oNot = int.Parse(Console.ReadLine());
                    tnot += oNot;
                }
                if (tnot < 55)
                {
                    Console.WriteLine(i + ".Öğrenci aldıgı not:" +(tnot / knot)+"oldugu için kaldı" );
                    Console.WriteLine(i + ".Öğrencinin not ortalaması: " + (tnot / knot));
                }
                else
                {
                    Console.WriteLine(i + ".Öğrenci aldıgı not:" + (tnot / knot) + " oldugu için geçti");
                    Console.WriteLine(i + ".Öğrencinin not ortalaması: " + (tnot / knot));
                }
            }
            Console.ReadLine();
        }
    }
}
