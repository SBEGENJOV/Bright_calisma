using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bas:
            Console.WriteLine("Bilgisayar için 1 i");
            Console.WriteLine("Beyaz eşya için 2 i");
            Console.WriteLine("Telefon için 3 i");
            int sec=Convert.ToInt32(Console.ReadLine());
            try 
            {
                switch (sec)
                {
                    case 1:
                        sec1:
                        Console.WriteLine("Notbook için a i");
                        Console.WriteLine("Desktop için b i");
                        Console.WriteLine("Tablet için c i");
                        string bsec=Console.ReadLine();
                        Random ucret = new Random();
                        switch(bsec)
                        {
                            case "a":
                                Console.WriteLine("Bilgisayar için Marka giriniz: ");
                                string marka=Console.ReadLine();
                                if (marka =="asus" || marka == "lenova")
                                {
                                    int deg=ucret.Next(10000,20000);
                                    deg += deg * 5 / 100;
                                    deg += deg * 18 / 100;
                                    Console.WriteLine("Bilgisayar ücreti: " + deg);
                                }
                                else if (marka == "dell" || marka == "casper")
                                {
                                    int deg = ucret.Next(8000, 15000);
                                    deg += deg * 7 / 100;
                                    deg += deg * 20 / 100;
                                    Console.WriteLine("Bilgisayar ücreti: " + deg);
                                }
                                else
                                {
                                    int deg = ucret.Next(20000, 30000);
                                    deg += deg * 10 / 100;
                                    deg += deg * 30 / 100;
                                    Console.WriteLine("Bilgisayar ücreti: " + deg);
                                }
                                    break;
                            case "b":
                                Console.WriteLine("donanım bilgisi giriniz: ");
                                string don=Console.ReadLine();
                                Console.WriteLine("İnç bilgisi giriniz: ");
                                int inc = Convert.ToInt32(Console.ReadLine());
                                if ((inc ==20 || inc==24) && don=="full")
                                {
                                    int fiy = ucret.Next(25000, 30000);
                                    fiy -= fiy * 15 / 100;
                                    Console.WriteLine("Donanım ücreti: " + fiy);
                                }
                                else if(inc ==15 || inc == 20)
                                {
                                    int fiy = ucret.Next(25000, 30000);
                                    fiy -= fiy * 25 / 100;
                                    Console.WriteLine("Donanım ücreti: " + fiy);
                                }
                                break;
                            case "c":
                                Console.WriteLine("Tablet fiyatını giriniz: ");
                                float tfiy=Convert.ToSingle(Console.ReadLine());
                                if (tfiy >= 10000)
                                {
                                    tfiy += tfiy * 30 / 100;
                                    Console.WriteLine("Tablet ücreti: " + tfiy);
                                }
                                else if(tfiy <= 10000)
                                {
                                    tfiy += tfiy * 27.5f / 100;
                                    Console.WriteLine("Tablet ücreti: " + tfiy);
                                }
                                break;
                            default:
                                Console.WriteLine("Girilen deger maalesef yalnış, tekrar dene");
                                goto sec1;
                                break;
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
            }
            }
            catch 
            { 
                Console.WriteLine("hatalı işlem gerçekleşti, tekrar deneyin");
                goto bas;
            }
            Console.ReadLine();
        }
    }
}
