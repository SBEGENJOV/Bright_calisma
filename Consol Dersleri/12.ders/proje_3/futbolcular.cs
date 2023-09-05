using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_3
{
    internal class futbolcular
    {
        public string adSoyad;
        public int formaNo;
        public string mevki;
        public double bonservis;
        public string memleket;
        public string takım;
        public int yas;
        public string durum;

        public void veriAl()
        {
            Console.WriteLine("Ad soyad giriniz: ");
            adSoyad = Console.ReadLine();
            Console.WriteLine("Forma no giriniz: ");
            formaNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Mevki giriniz: ");
            mevki = Console.ReadLine();
            Console.WriteLine("Bonservis giriniz: ");
            bonservis = double.Parse(Console.ReadLine());
            Console.WriteLine("Takım giriniz: ");
            takım=Console.ReadLine();
            Console.WriteLine("Yas giriniz: ");
            yas = int.Parse(Console.ReadLine());
            Console.WriteLine("Durum giriniz: ");
            durum = Console.ReadLine();
        }
        public void yazdir()
        {
            Console.WriteLine("Bonservisiz: "+bonservis);
            Console.WriteLine("Takımı: "+takım);
        }
    }
}
