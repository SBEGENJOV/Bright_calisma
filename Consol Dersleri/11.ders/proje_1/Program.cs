using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class Program
    {
        //her yerden erişilebilir bir metot tanımlayacam STATİC yazarsak her yerden erişilebilir.
        static int fiyat;
        static void anamenu(int secim)
        {
            
            if (secim==1)
            {
                Console.WriteLine("m-mercimek");
                Console.WriteLine("t-tarhana");
                char corba=char.Parse(Console.ReadLine());
                switch (corba)
                {
                    case 'm':
                        fiyat += 30;
                        int tutar = fis(fiyat);
                        Console.WriteLine("Ödemeniz gereken tutar: " + tutar);
                        break;
                    case 't':
                        fiyat += 50;
                        int tutar2 = fis(fiyat);
                        Console.WriteLine("Ödemeniz gereken tutar: " + tutar2);
                        break;
                }
            }
            else if(secim==2)
            {
                fiyat += 75;
                int tutar = fis(fiyat);
                Console.WriteLine("Ödemeniz gereken tutar: " + tutar);
            }
           
        }
        static int fis(int fiyat)
        {
            Console.WriteLine("İçecek ister mısnız");
            string durum=Console.ReadLine();
            if (durum=="evet")
            {
                fiyat += 40;
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
            Console.WriteLine("1-Çorba");
            Console.WriteLine("2-sebze");
            int secim = int.Parse(Console.ReadLine());
            //anamenü adına menu çagırazcaz
            anamenu(secim);
            Console.WriteLine("İşleme devam etmek istiyormusunuz");
            string islem=Console.ReadLine();
            if (islem == "evet")
            {
                goto go;
            }
            Console.ReadLine();
        }
    }
}
