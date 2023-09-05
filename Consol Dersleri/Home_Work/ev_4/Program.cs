using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_4
{
    internal class Program
    {
        static void sayi(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a+" SAYISI BÜYÜKTÜR");
            }
            else
            {
                Console.WriteLine(b + " SAYISI BÜYÜKTÜR");
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("1.Sayıyı gir: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı gir: ");
            //int b = int.Parse(Console.ReadLine());
            //sayi(a,b);
            string kelime = "devamı";
            foreach (Char item in kelime)
            {
                if (item=='a')
                {
                    break;
                }
                Console.WriteLine("0");
            }
            Console.WriteLine("1");
            Console.ReadLine();
        }
    }
}
