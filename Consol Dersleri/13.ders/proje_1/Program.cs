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
            
            Console.WriteLine("1-Standart");
            Console.WriteLine("2-Vip");

            int durum=int.Parse(Console.ReadLine());
            if (durum==1)
            {
                musteriler musteriler = new musteriler();
                Console.WriteLine("Strandart Müşteri ekranı");
                Console.WriteLine("Müşteri no girin: ");
                musteriler.MusteriNo=int.Parse(Console.ReadLine());
                Console.WriteLine("Lütfen AdSoyad girin: ");
                musteriler.AdSoyad=Console.ReadLine();
                Console.WriteLine("Müşteri Tel no: ");
                musteriler.TelNo=Console.ReadLine();
                Console.WriteLine("Mail giriniz: ");
                musteriler.Mail=Console.ReadLine();
               Console.WriteLine("Bakiye girin: ");
                musteriler.Bakiye=int.Parse(Console.ReadLine());
                musteriler.yazdir();
            }
            else
            {
                musteriler musteriler = new musteriler();
                Console.WriteLine("VİP Müşteri ekranı");
                Console.WriteLine("Strandart Müşteri ekranı");
                Console.WriteLine("Müşteri no girin: ");
                musteriler.MusteriNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Lütfen AdSoyad girin: ");
                musteriler.AdSoyad = Console.ReadLine();
                Console.WriteLine("Müşteri Tel no: ");
                musteriler.TelNo = Console.ReadLine();
                Console.WriteLine("Mail giriniz: ");
                musteriler.Mail = Console.ReadLine();
                Console.WriteLine("Bakiye girin: ");
                musteriler.Bakiye = int.Parse(Console.ReadLine());
                Console.WriteLine("Güncel fiyat: "+musteriler.vip(musteriler.Bakiye));
            }
            Console.ReadLine();
        }
    }
}
