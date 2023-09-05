using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int [] sayi = new int[10];
            int sayac = 0,top=0;
            for (int i = 0; i < sayi.Length; i++) 
            {
                Console.WriteLine("Lütfen sayı girin: ");
                sayi[i] = int.Parse(Console.ReadLine());
                if (sayi[i]%8==0 && sayi[i] % 5==0)
                {
                    sayac++;
                    top += sayi[i];
                }
            }
            Console.WriteLine("8 ve 5 in katı olan sayılar: "+top);
            Console.WriteLine("8 ve 5 in katı olan sayıların adeti: "+sayac);
            Console.ReadLine();
        }
    }
}
