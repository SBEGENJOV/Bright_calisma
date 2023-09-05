using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int top = 0;
            while (true)
            {
                Console.WriteLine("Lütfen sayı giriniz: ");
                int say = int.Parse(Console.ReadLine());
                if (say == 15)
                {
                    Console.WriteLine("Girilen sayı 5 program biter :)");
                    break;
                }
                else
                {
                    top += say;
                    Console.WriteLine("Girilen sayıların toplamı: " + top);
                }
            }
            Console.ReadLine();
        }
    }
}
