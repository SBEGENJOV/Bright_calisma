using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_10
{
    internal class Program
    {
        //class ın içinde main methodunun dışında olcak metot tanımlmaları.
        static void hesapla()
        {
            int fiyat = 100;
            fiyat += 20;
            Console.WriteLine("Ödemeniz gereken tutar: "+fiyat);
        }
        static void zam(int fiyat)
        {
            
            fiyat += 50;
            Console.WriteLine("Ödemeniz gerek tutar: " + fiyat);
        }
        static void mesaj()
        {
            Console.WriteLine("İyi alışverişler");
        }
        static void Main(string[] args)
        {
            //tanımlanan metotları main içerisinde çagırarak kullanabiliriz.
            mesaj();
            hesapla();
            zam(500);
            Console.ReadLine();
        }
    }
}
