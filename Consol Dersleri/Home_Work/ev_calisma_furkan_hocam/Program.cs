using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ev_calisma_furkan_hocam
{
    internal class Program
    {
        static int[] sayi = new int[10];
        static void diziAl()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + ".Sayi gir: ");
                sayi[i] = int.Parse(Console.ReadLine());
            }
        }
        static void diziKucuk(int[] sayi)
        {
            //diziAl();
            int sayac = 10, gecici = 0;
            foreach (int sayitek in sayi)
            {
                sayac--;
                for (int i = sayac - 1; i >= 0; i--)
                {
                    if (sayi[sayac] < sayi[i])
                    {
                        gecici = sayi[i];
                        sayi[i] = sayi[sayac];
                        sayi[sayac] = gecici;
                    }
                }
            }
        }

        static void diziBuyuk(int[] sayi)
        {
            //diziAl();
            int sayac = -1, gecici = 0;
            foreach (int sayitek in sayi)
            {
                sayac++;
                for (int i = sayac + 1; i <= 9; i++)
                {
                    if (sayi[sayac] < sayi[i])
                    {
                        gecici = sayi[i];
                        sayi[i] = sayi[sayac];
                        sayi[sayac] = gecici;
                    }
                }
            }
        }
        static void yazdir() 
        {
            diziAl();
            Console.WriteLine("Sayıları hangi sıralama ile görmek istersiniz: ");
            string cevap =Console.ReadLine();
            string cevapKucuk=cevap.ToLower();
            if (cevapKucuk=="büyük")
            {
                diziBuyuk(sayi);
                Console.WriteLine("Sayıların büyükten küçüge yazılım şekili: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine((i+1) + ".Sayı: " + sayi[i]);
                }
            }
            else
            {
                diziKucuk(sayi);
                Console.WriteLine("Sayıların küçükten büyüge yazılım şekili: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine((i + 1) + ".Sayı: " + sayi[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            yazdir();
            Console.ReadLine();
            
        }
    }
}
