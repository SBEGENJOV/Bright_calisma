using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ec_metotlar2
{
    internal class Program
    {
        static void girisMetin()
        {
            Console.WriteLine("Değerli öğrenci HOŞ GELDİNİZ, Kurs fiyatı 50.000 TL üzerinden değerlendirilecektir");
        }

        private static void siralama(int sira)
        {

            int fiyat = 50000;
            
                if (sira <= 10000)
                {
                    Console.WriteLine("Tebrikler ilk 10.000 içindesiniz, Bursunuz 100% dür. Kurstan bedavaya yararlanacaksınız");
                }
                else if (sira > 10000 && sira <= 20000)
                {
                    fiyat -= fiyat * 80 / 100;
                    Console.WriteLine("Tebrikler ilk 20.000 içindesiniz, Bursunuz 80% dür. Kursa ödeyeceginiz tutar: " + fiyat);
                }
                else if (sira > 20000 && sira <= 35000)
                {
                    fiyat -= fiyat * 65 / 100;
                    Console.WriteLine("Tebrikler ilk 35.000 içindesiniz, Bursunuz 65% dür. Kursa ödeyeceginiz tutar: " + fiyat);
                }
                else if (sira > 35000 && sira <= 55000)
                {
                    fiyat -= fiyat * 50 / 100;
                    Console.WriteLine("Tebrikler ilk 55.000 içindesiniz, Bursunuz 50% dür. Kursa ödeyeceginiz tutar: " + fiyat);
                }
                else if (sira > 50000 && sira <= 80000)
                {
                    fiyat -= fiyat * 35 / 100;
                    Console.WriteLine("Tebrikler ilk 80.000 içindesiniz, Bursunuz 35% dür. Kursa ödeyeceginiz tutar: " + fiyat);
                }
                else if (sira > 80000 && sira <= 150000)
                {
                    fiyat -= fiyat * 25 / 100;
                    Console.WriteLine("Tebrikler ilk 150.000 içindesiniz, Bursunuz 25% dür. Kursa ödeyeceginiz tutar: " + fiyat);
                }
                else
                {
                    Console.WriteLine("Lütfen Halkla ilişkilerle görüşün");
                }
        }
        static void cikisMetin()
        {
            Console.WriteLine("Sağlıklı günler dileriz. Yine bekleriz");
        }
        static void Main(string[] args)
        {
            girisMetin();
            Console.WriteLine("Deger gir: ");
            int degerr = int.Parse(Console.ReadLine());
            siralama(degerr);
            Console.ReadLine();
        }
    }
}
