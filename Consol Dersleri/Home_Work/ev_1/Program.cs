using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("Lütfen kaç isim gireceginizi girin: ");
            int say=int.Parse(Console.ReadLine());
            string[] isimler = new string[say];
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine("isim girin: ");
            //    isimler[i] = Console.ReadLine();
            //}--------------------------------------------- for ile tersten yazma --------------------------
            //Console.WriteLine(isimler.Length);
            //for (int i = isimler.Length-1; i >=0; i--)
            //{
            //    Console.WriteLine(isimler[i]);
            //}---------------------------------------------foreach ile tersten yazma------------------------
            //for(int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine("isim girin: ");
            //    isimler[i] = Console.ReadLine();
            //    sayac++;

            //}
            //foreach (string isim in isimler)
            //{
            //    Console.WriteLine(isimler[sayac-1]);
            //    sayac--;
            // }----------------------------------------while ile listeyi tersten yazma-------------------------
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine("isim girin: ");
            //    isimler[i] = Console.ReadLine();
                
            //}
            //while ((say+say+4)>sayac)
            //{
            //    Console.WriteLine(isimler[say-1]);//gh,gf,fd,ds,
            //    sayac++;//1,2,3,4
            //    say--;//8,6,4,2
            //}
                Console.ReadLine();
        }
    }
}
