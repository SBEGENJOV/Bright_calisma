using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{
    internal class yurtici
    {
        string guzergah;
        string ucretliYol;
        string durum;
        string tasımaDurum;
        string bolge;
        string isTuru;
        string vasıtaNo;
        int fiyat;
        int elemanSaysi;

        public string GUZERGAH
        {
            get { return guzergah; }
            set { guzergah = value; }
        }
        public string UCRETLİYOL
        {
            get { return ucretliYol; }
            set { ucretliYol = value; }
        }
        public string DURUM
        {
            get { return durum; }
            set { durum = value; }
        }
        public string TASİMADURUM
        {
            get { return tasımaDurum; }
            set { tasımaDurum = value; }
        }
        public string BOLGE
        {
            get { return bolge; }
            set { bolge = value; }
        }
        public string ISTURU
        {
            get { return isTuru; }
            set { isTuru = value; }
        }
        public string VASITANO
        {
            get { return vasıtaNo; }
            set
            {
                if (value.Length == 6)
                {
                    vasıtaNo = value;
                }
                else { Console.WriteLine("OLUMSUZ DEGER"); }
            }
        }
        public int FIYAT
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        public int ELEMANSAYISI
        {
            get { return elemanSaysi; }
            set { elemanSaysi = value; }
        }
        //-------------------------------------------------------FEİLDLER BİTTİ------------------------------------
        public void veriAl()
        {
            Console.WriteLine("Güzergah giriniz: ");
            GUZERGAH = Console.ReadLine();
            Console.WriteLine("Yol türünü(ücretli mi/ücretsiz mi) giriniz: ");
            UCRETLİYOL = Console.ReadLine();
            Console.WriteLine("Şehiriçi mi yoksa Şehirdışı mı: ");
            DURUM = Console.ReadLine();
            Console.WriteLine("Hangi bölgedeye gideceksiniz: ");
            BOLGE = Console.ReadLine();
            Console.WriteLine("Çalışma türünü girin(Bireysel mi/ Kurumsal mı): ");
            ISTURU = Console.ReadLine();
            Console.WriteLine("Vasıta Numarası girin giriniz: ");
            VASITANO = Console.ReadLine();
            Console.WriteLine("Yolculuk fiyatını girin: ");
            FIYAT = int.Parse(Console.ReadLine());
            Console.WriteLine("Kaç eleman çalıştırıyorsunuz: ");
            ELEMANSAYISI = int.Parse(Console.ReadLine());
        }
        public int metot1(int elemansayi, int fiyat)
        {
            if (elemansayi < 10)
            {
                return fiyat;
            }
            else if (elemansayi > 10 && elemansayi < 30)
            {
                elemansayi *= 1000;
                fiyat += elemansayi * 30 / 100;
                return fiyat;
            }
            else if (elemansayi > 30)
            {
                elemansayi *= 1000;
                fiyat += elemansayi * 50 / 100;
                return fiyat;
            }
            else
            {
                Console.WriteLine("Tesr giden bir şeyler var");
                return fiyat;
            }
        }
        public int metot2(int fiyat, string bölge, string isturu)
        {
            if (bolge == "doguanadolu" && isturu == "bireysel")
            {
                fiyat += (fiyat * 5 / 100) + (fiyat * 7 / 100) + 1000;
                return fiyat;
            }
            else if (bolge == "marmara" && isturu == "kurumsal")
            {
                fiyat -= fiyat * 20 / 100;
                return fiyat;
            }
            else if (bolge == "ege" && isturu == "bireysel")
            {
                fiyat += fiyat * 20 / 100;
                return fiyat;
            }
            else
            {
                Console.WriteLine("Tesr giden bir şeyler var");
                return fiyat;
            }
        }
        public int metot3(int fiyat)
        {
            if (durum == "şehiriçi")
            {
                Console.WriteLine("Birim yakıt fiyatı girn:");
                int brimyakit = int.Parse(Console.ReadLine());
                Console.WriteLine("Km girn:");
                int km = int.Parse(Console.ReadLine());
                fiyat += (km * brimyakit) * 30 / 100;
                return fiyat;
            }
            else if (durum == "şehirdışı")
            {
                Console.WriteLine("Birim yakıt fiyatı girn:");
                int brimyakit = int.Parse(Console.ReadLine());
                Console.WriteLine("Km girn:");
                int km = int.Parse(Console.ReadLine());
                fiyat += (km * brimyakit) * 130 / 100;
                return fiyat;
            }
            else
            {
                Console.WriteLine("Tesr giden bir şeyler var");
                return fiyat;
            }
        }
        public void metot4(int fiyat, string isturu, string tasimaDurum)
        {
            if (isturu == "kurumsal")
            {
                Console.WriteLine("Üyelik varmı: ");
                string uyeKontrol = Console.ReadLine();
                if (uyeKontrol == "evet")
                {
                    if (tasimaDurum == "kara")
                    {
                        fiyat -= fiyat * 20 / 100;
                        Console.WriteLine("Son ödemeniz gereken tutar: " + fiyat);
                    }
                    else if (tasimaDurum == "deniz")
                    {
                        fiyat -= fiyat * 35 / 100;
                        Console.WriteLine("Son ödemeniz gereken tutar: " + fiyat);
                    }
                }
                else
                {
                    Console.WriteLine("Son ödemeniz gereken tutar: " + fiyat);
                }
            }
            else if (isturu == "bireysel")
            {
                Console.WriteLine("Daha önce bizimle çalıştınız mı: ");
                string calısKontrol = Console.ReadLine();
                if (calısKontrol == "evet")
                {
                    fiyat -= fiyat * 5 / 100;
                    Console.WriteLine("Son ödemeniz gereken tutar: " + fiyat);
                }
                else
                {
                    Console.WriteLine("Son ödemeniz gereken tutar: " + fiyat);
                }
            }
        }
        public int Uyol(int fiyat)
        {
            if (UCRETLİYOL == "ücretli")
            {
                fiyat += 100;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }
        public void yazdir()
        {
            veriAl();
            int fiyat1 = metot1(ELEMANSAYISI, FIYAT);
            int fiyat2 = metot2(fiyat1, BOLGE, ISTURU);
            int fiyat3 = metot3(fiyat2);
            int fiyat4 = Uyol(fiyat3);
            metot4(fiyat4, ISTURU, TASİMADURUM);
        }
    }
}
