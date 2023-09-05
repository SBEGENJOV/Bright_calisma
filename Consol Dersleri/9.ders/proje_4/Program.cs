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
            Random rand = new Random();
            int[] sayi = new int[10];
            int[] ek = new int[10];
            int sayac = 0, top = 0,stop=0;
            for (int i = 0; i < sayi.Length; i++)
            {
                int say = rand.Next(1, 301);
                sayi[i] = say;
                Console.WriteLine(i+1+".Rastgele üretilen sayı: " + sayi[i]);
                if (say%10==0)
                {
                    top += say;
                    sayac++;
                    sayi[i] += say*20/100;
                    ek[sayac] = sayi[i];
                    //Console.WriteLine("sonu 0 ile biten sayının eksiz hali: " + say);
                }
            }
            for (int i = 0; i < ek.Length; i++)
            {
                if (ek[i]!=0)
                {
                    stop += ek[i];
                    Console.WriteLine("sonu 0 ile biten sayının eklenmiş halleri: " + ek[i]);
                }
            }
            Console.WriteLine("sonu 0 ile %20 eklenmişlerin toplamı: " + stop);
            Console.WriteLine("sonu 0 ile bitenlerin toplamı: " + top);
            Console.WriteLine("sonu 0 ile bitenlerin adeti: " + sayac);
            Console.ReadLine();
        }
    }
}
