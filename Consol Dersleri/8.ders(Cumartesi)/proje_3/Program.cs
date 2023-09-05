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
            int tsay = 0;
            while (true)
            {
                Console.WriteLine("Lütfen sayı giriniz: ");
                int say = int.Parse(Console.ReadLine());
                if (say%2!=0)
                {
                    tsay += say;
                    Console.WriteLine("Girilen tek sayıların toplamı: " + tsay);
                }
                else
                {
                    Console.WriteLine("Girilen sayı çift program biter :)");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
