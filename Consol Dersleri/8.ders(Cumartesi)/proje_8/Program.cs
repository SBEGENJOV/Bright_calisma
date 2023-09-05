using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int top = 0;
            Random rand = new Random();
            while (true)
            {
                int say = rand.Next(1, 101);
                top += say;
                if (top >1000)
                {
                    Console.WriteLine("Rastgele üretilen sayıların toplamı: " + top);
                    break;
                }
            }
            Console.ReadLine();
        }
            
    }
}
