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
            int kztut = 0;
            Console.WriteLine("Kiraya ne zaman başladı: ");
            int kbas=int.Parse(Console.ReadLine());
            Console.WriteLine("Kiraya ne zaman biticek: ");
            int kbit = int.Parse(Console.ReadLine());
            Console.WriteLine("Kiraya ne kadar ödeyerek başladı: ");
            int ktut = int.Parse(Console.ReadLine());
            if (kbit>kbas)
            {
                Console.WriteLine("Lütfen tarihlerini kontrol et hata var!");
            }
            else
            {
                while (kbas < kbit)
                {
                    kbas++;
                    ktut += kbas * 25 / 100;
                    kztut = kbas * 25 / 100;

                }
            }
            Console.WriteLine("Kira bitiş tarihinde ödenecek tutar: " + ktut);
            Console.WriteLine("Kiraya yapılan zam toplam tutar: " + kztut);
            Console.ReadLine();
        }
    }
}
