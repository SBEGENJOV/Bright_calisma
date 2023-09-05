using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bas:
            en:
            Console.WriteLine("Üretim için 1 baınız");
            Console.WriteLine("İthalat için 2 baınız");
            Console.WriteLine("İhracat için 3 baınız");
            try 
            {
                int Deger =Convert.ToInt32(Console.ReadLine());
                switch (Deger)
                {
                    case 1:
                        Console.WriteLine("Hammadde üretimi 100 ile 200 arasında değer giriniz: ");
                        int UretimMiktar=Convert.ToInt32(Console.ReadLine());
                        if (UretimMiktar >= 100 && UretimMiktar<=200)
                        {
                            int MalF = 500;
                            MalF *= UretimMiktar;
                            MalF += MalF * 20 / 100;
                            Console.WriteLine("Vergili ham madde tutarı: " + MalF);
                        }
                        else
                        {
                            int HamU = 2000;
                            HamU *= UretimMiktar;
                            Console.WriteLine("Vergisiz üretim fiyatı: "+HamU);
                        }
                        break;
                    case 2:
                        Console.WriteLine("İthalat ekranına hoş geldiniz");
                        Console.WriteLine("Ülke Adını giriniz: ");
                        string Ulke = Console.ReadLine();
                        Console.WriteLine("Taşıma yolu giriniz: ");
                        string Ulasım = Console.ReadLine();
                        if ((Ulke == "italya" || Ulke == "fransa") && Ulasım == "ddeniz")
                        {
                            Console.WriteLine("Deniz seferleri");
                        }
                        else if ((Ulke == "almanya" || Ulke == "ispanya") && Ulasım == "kara")
                        {
                            Console.WriteLine("Kara seferleri");
                        }
                        else
                        {
                            Console.WriteLine("Diğer sefer yok, İyi günler");
                        }
                        break;
                    case 3:
                        Random Ucter= new Random();
                        Console.WriteLine("Tekonoloji firması ise 1 e basınız");
                        Console.WriteLine("Sanayı firması ise 2 e basınız");
                        Console.WriteLine("Ekonomi ve Kalkınma firması ise 3 e basınız");
                        char Secim=Convert.ToChar(Console.ReadLine());
                        switch(Secim)
                        {
                            case '1':
                                int Tutar=Ucter.Next(3000,7500);
                                Console.WriteLine("Teknoloji için ödnecek tutar: "+Tutar);
                                break;
                            case '2':
                                int sTutar = Ucter.Next(7500, 9000);
                                Console.WriteLine("Sanayi için ödnecek tutar: " + sTutar);
                                break;
                            case '3':
                                int kTutar = Ucter.Next(9000, 12000);
                                Console.WriteLine("Ekonomi ve Kalkınma için ödnecek tutar: " + kTutar);
                                break;
                            default: 
                                Console.WriteLine("Başka seçenek yok");
                                break;
                        }
                            
                        break;
                    default:

                        Console.WriteLine("Hata yakalandı, tekrar deneyin");
                        break;

                }
            }
            catch 
            {
                Console.WriteLine("Hata yakalandı, tekrar deneyin");
                goto bas;
            }
            Console.WriteLine("Menuye dönmek istersenir True yazınız: ");
            bool sec=Convert.ToBoolean(Console.ReadLine());
            if (sec)
            {
                Console.Clear();
                goto en;
            }

            Console.ReadLine();
        }
    }
}
