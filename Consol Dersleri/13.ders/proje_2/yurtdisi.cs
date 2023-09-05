using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{
    //guzergah
    //ucretliyol(var ise ucretliyol=100 yok ise 0 tl ata)
    //durum(şehiriçi-şehirdışı)
    //tasımadurum(ne taşıyor)
    //bolge
    //iş türü
    //vasıtano(6 karekter olacak)
    //elemansayısı

    //m1 verial 
    //m2 eleman sayısı 10 dan az ise fiyat oldugu gibi kalsın- 10 ile 30 arasında ise eleman sayısı 10 dan fazla ise elemansayı*1000*30kdv ekle
    // eğer 30 dan fazla ise fiyata + elemansayısı 10 dan fazla olan elemankadar*1000+%50kdv ekle
    //m3 bölge doguanadolu ise isturu bireysel ise fiyat üzerinden kdv%5+ötv%7 ve 1000 tl ekstra mesai ücreti alıcan
    //bölge marmara ve isturu kurumsal ise fiyat+%20 
    //m4 durum eger sehir ici ise km degeri girilsin ve km*birimyakıtfiyatı(benzin fiyatı) üzerinden %30 kar oranı ile fiyatı ekle
    //sehir dışı ise km degeri girilsin ve km*birimyakıtfiyatı(benzin fiyatı) üzerinden %130 kar oranı ile fiyatı ekle
    internal class yurtdisi
    {
        string ulkeAdi;
        string sehir;
        string vasitatip;
        int km;
        int fiyat;
        int komisyon;
        public string sorumluKisi;


        public string uAd
        {
            get
            {
                return ulkeAdi;
            }
            set
            {
                if (value == "brezilya" || value == "meksika")
                {
                    Console.WriteLine("olumsuz ulke");
                }
                else
                {
                    ulkeAdi = value;
                }
            }
        }

        public string vTakip
        {
            get
            {
                return vasitatip;
            }
            set
            {
                if (value == "motor" || value == "minibus")
                {
                    Console.WriteLine("olumsuz değer");
                }
                else
                {
                    vasitatip = value;
                }
            }
        }

        public int KM
        {
            get
            {
                return km;
            }
            set
            {
                if (value>500 && value < 25000)
                {
                    km = value; 
                }
                else
                {
                    Console.WriteLine("olumsuz KM");
                }
            }
        }

        public int Fiyat
        {
            get
            {
                return fiyat;
            }
            set
            {
                if (value > 3000 && value < 15000)
                {
                    fiyat = value;
                }
                else
                {
                    Console.WriteLine("olumsuz fiyat");
                }
            }
        }

        public void VeriAl()
        {
            Console.WriteLine("Ülke Adı girin: ");
            uAd = Console.ReadLine();
            Console.WriteLine("Şehie Adı girin: ");
            sehir = Console.ReadLine();
            Console.WriteLine("Vasıta girin: ");
            vTakip = Console.ReadLine();
            Console.WriteLine("Km girin: ");
            KM = int.Parse(Console.ReadLine());
            Console.WriteLine("Fiyat girin: ");
            Fiyat = int.Parse(Console.ReadLine());
            Console.WriteLine("Sorumlu kişinin Adını girin: ");
            sorumluKisi = Console.ReadLine();
            Console.WriteLine("Komisyon girin: ");
            komisyon = int.Parse(Console.ReadLine());
        }
        public void VeriYaz()
        {
            Console.WriteLine("Ülke Adı girin: " + ulkeAdi);
            Console.WriteLine("Şehie Adı girin: " + sehir);
            Console.WriteLine("Vasıta girin: " + vasitatip);
            Console.WriteLine("Km girin: " + km);
            Console.WriteLine("Fiyat girin: " + fiyat);
            Console.WriteLine("Sorumlu kişinin Adını girin: " + sorumluKisi);
            Console.WriteLine("Komisyon girin: " + komisyon);
        }
        public void KomisyonHesap()
        {
            VeriAl();
            if (ulkeAdi=="fransa" && km<1500)
            {
                komisyon += komisyon * 20 / 100;
            }
            else
            {
                komisyon += komisyon * 30 / 100;
            }
        }
        public int VasitaHesap(int Komisyon)
        {
            KomisyonHesap();
            if (vTakip=="ucak" || vTakip == "helikopter")
            {
                fiyat += km * komisyon;return fiyat;
            }
            else if (vTakip == "gemi")
            {
                fiyat += km * komisyon;
                fiyat -= fiyat * 12 / 100; return fiyat;
            }
            else if (vTakip == "kamyon" || vTakip == "tır")
            {
                fiyat += km * fiyat;
                fiyat -= fiyat * 7 / 100; return fiyat;
            }
            else
            {
                Console.WriteLine("Girilen vsıta tipiuygun değil"); return komisyon;
            }
        }
        public void yazdir()
        {
            Console.WriteLine("Son ödemeniz gereken tutar: "+ VasitaHesap(komisyon));
        }
    }
}
