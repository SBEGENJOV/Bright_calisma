using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] sayi = new int[10];
            int sayac = 0, top = 0;
            for (int i = 0; i < sayi.Length; i++)
            {
                int say = rand.Next(1, 201);
                sayi[i] = say;
                if (say<100)
                {
                    sayac++;
                    Console.WriteLine("100 den küçük olan sayılar: " + say);
                }
            }
            
            Console.WriteLine("100 en küçük sayıların adeti: " + sayac);
            Console.ReadLine();
        }
    }
}
