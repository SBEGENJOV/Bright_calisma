using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{
    internal class Program
    {
        static int fiyat= 0;
        static void anamenu(int secim)
        {
            
            if (secim == 1)
            {
                Console.WriteLine("Alacagınız takım Karaca veya Porselen mi ?");
                string Ytakım = Console.ReadLine();
                if (Ytakım=="evet")
                {
                    fiyat += 5000;
                    int tutar = fis(fiyat);
                    Console.WriteLine("Ödemeniz gereken tutar: " + tutar);
                }
                else
                {
                    fiyat += 3000;
                    int tutar = fis(fiyat);
                    Console.WriteLine("Ödemeniz gereken tutar: " + tutar);
                }
            }
            else if (secim == 2)
            {
                Console.WriteLine("Alacagınız takım Tam paket mi");
                string Ttakım = Console.ReadLine();
                if (Ttakım == "evet")
                {
                    fiyat += 7500;
                    int tutar = fis(fiyat);
                    Console.WriteLine("Ödemeniz gereken tutar: " + tutar);
                }
                else
                {
                    Console.WriteLine("Kaç parca alacaksınız: ");
                    int parca=int.Parse(Console.ReadLine());
                    fiyat += parca * 750;
                    int tutar = fis(fiyat);
                    Console.WriteLine("Ödemeniz gereken tutar: " + tutar);
                }
            }

        }
        static int fis(int fiyat)
        {
            Console.WriteLine("İndirimde Ütü var ister mısnız");
            string durum = Console.ReadLine();
            if (durum == "evet")
            {
                fiyat +=1000;
                fiyat+=fiyat* 10 / 100;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }
        static void Main(string[] args)
        {
            go:
            Console.WriteLine("1-Yemek takımı");
            Console.WriteLine("2-Tencere takımı");
            int secim = int.Parse(Console.ReadLine());
            anamenu(secim);
            Console.WriteLine("İşleme devam etmek istiyormusunuz");
            string islem = Console.ReadLine();
            if (islem == "evet")
            {
                goto go;
            }
            Console.ReadLine();
        }
    }
}
