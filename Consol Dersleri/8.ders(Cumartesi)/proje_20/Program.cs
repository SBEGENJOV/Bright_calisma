using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int katop = 0,kutop=0;
            int[] sayi=new int[10];
            Random random = new Random();
            for(int i = 0; i < sayi.Length; i++)
            {
                sayi[i] = random.Next(4, 61);
                if (sayi[i]%2==0)
                {
                    Console.WriteLine("Alınan rastgele değer: " + sayi[i]);
                    katop += sayi[i] * sayi[i];

                }
                else
                {
                    Console.WriteLine("Alınan rastgele değer: " + sayi[i]);
                    kutop += sayi[i] * sayi[i]* sayi[i];
                }
            }
            Console.WriteLine("Karelerin toplamı: " + katop);
            Console.WriteLine("Küplerin toplamı: " + kutop);
            Console.ReadLine();
        }
    }
}
