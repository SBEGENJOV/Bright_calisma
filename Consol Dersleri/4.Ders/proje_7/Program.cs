using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        go:
            try
            {
                Console.WriteLine("1-Gemi");
                Console.WriteLine("2-Marmaray");
                Console.WriteLine("3-Otobüs");
                Console.WriteLine("Seçim yap");
                int secim=Convert.ToInt32(Console.ReadLine());
                if (secim == 1) 
                {
                    Console.WriteLine("gemiye hoşgeldiniz");
                    Console.WriteLine("A-Anadolu yakası");
                    Console.WriteLine("B-Kıtalar arası geçiş");
                    char tur=Convert.ToChar(Console.ReadLine());
                    if(tur == 'A')
                    {
                        Random tUcret = new Random();
                        int tucreta=tUcret.Next(70,101);
                        Console.WriteLine("Tutar: "+tucreta);
                    }
                    else
                    {
                        Random tUcret = new Random();
                        int tucreta = tUcret.Next(200, 300);
                        Console.WriteLine("Tutar: "+tucreta);
                    }
                }
                else if (secim == 2)
                {
                    Console.WriteLine("Kaç durak gideceksiniz ?");
                    int dur = Convert.ToInt32(Console.ReadLine()) ;
                    if (dur >= 0 && dur<5)  
                    {
                        Console.WriteLine("İade ücreti: 10TL");
                    }
                    else if(dur >= 5 && dur < 10)
                    {
                        Console.WriteLine("İade ücreti: 5TL");
                    }
                    else
                    {
                        Console.WriteLine("İade yok");
                    }
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Abonelik varmı ? ");
                    string abone=Console.ReadLine();
                    if (abone == "evet")
                    {
                        int Basim = 200, abonelik = 140;
                        int GSS=Convert.ToInt32(Console.ReadLine()) ;

                    }
                }
            }
            catch 
            {
                Console.WriteLine("Hata yakalandı, tekrar dene");
                Console.WriteLine("İşleme devam etmek ister misin? ");
                string islem=Console.ReadLine();
                if (islem == "evet")
                {
                    goto go;
                }
            }
            finally
            {
                Console.WriteLine("Programdan çıkıyorsun, İyi günler");
            }
            Console.ReadLine();
        }
    }
}
