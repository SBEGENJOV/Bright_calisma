using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_13
{
    internal class Program
    {
        //borsa için
        static double zam(int miktar)
        {
            Console.WriteLine("Fiyatı girin: ");
            double fiyat=double.Parse(Console.ReadLine());
            double tutar = miktar * fiyat;
            return tutar;
        }
        //Coin için
        static int OTV(int CoinTutar)
        {
            CoinTutar += CoinTutar * 60 / 100;
            return CoinTutar;   
        }
        static void Sistem(bool durum)
        {
            if (durum==true)
            {
                Console.WriteLine("Sisteme üye oldugun için 100 TL indirim kuponu kazandın");
            }
            else
            {
                Console.WriteLine("Üye ol gel");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("1-Borsa Piyasaları");
            Console.WriteLine("2-Coin Piyasaları");
            Console.WriteLine("3-Altın Piyasaları");
            int secim=int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Lot sayısını girin: ");
                    int lot=int.Parse(Console.ReadLine());
                    double tutar=zam(lot);
                    Console.WriteLine("Borsa piyasası: "+tutar);
                    Sistem(true);
                    break;
                case 2:
                    Console.WriteLine("Coin sayısını girin: ");
                    int coin = int.Parse(Console.ReadLine());
                    int sonuc = OTV(coin);
                    Console.WriteLine("Coin tutarı: " + sonuc);
                    Sistem(true);
                    break;
                case 3:
                    Console.WriteLine("Gr sayısını girin: ");
                    int gr = int.Parse(Console.ReadLine());
                    double bedel = zam(gr);
                    Console.WriteLine("Borsa piyasası: " + bedel);
                    Sistem(true);
                    break;
            }
            Console.ReadLine();
        }
    }
}
