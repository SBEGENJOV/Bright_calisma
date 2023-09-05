using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üye olmak ister misiniz ?");
            string soru=Console.ReadLine();
            if (soru == "evet" || soru=="Evet"||soru=="EVET")
            {
            go:
                Console.WriteLine("Kullanıcı adını giriniz: ");
                string Kullad = Console.ReadLine();
                if (Kullad == "admin" || Kullad == "Admin" || Kullad == "ADMIN")
                {
                sifre:
                    Console.WriteLine("Kullanıcı adı doğru şifre gir");
                    Console.WriteLine("Lütfen şifrenizi giriniz: ");
                    string Sifre = Console.ReadLine();
                    if (Sifre == "1553")
                    {
                        Console.WriteLine("Tebrikler şifre DOĞRU");
                        Console.Clear();
                        Console.WriteLine("Kaç aylık üye olmak istersiniz");
                        int sure=Convert.ToInt32(Console.ReadLine());
                        if(sure >=6 && sure<=12)
                        {
                            float tutar=100* 12.5f/100 ;
                            Console.WriteLine("Üyelik için ödemeniz gereken tutar: "+tutar*sure);
                        }
                        else
                        {
                            float tutar = 100 * 30.5f / 100;
                            Console.WriteLine("Üyelik için ödemeniz gereken tutar: " + tutar*sure);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yalnış şifre, Tekrar dene :)");
                        Console.WriteLine("İşleme devam etmek isremisiniz");
                        bool islem = Convert.ToBoolean(Console.ReadLine());
                        if (islem == true)
                        {
                            Console.Clear();
                            goto sifre;
                        }
                        else
                        {
                            Console.WriteLine("BYE BYE");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı yalnış, Tekrar deneyin");
                    Console.WriteLine("İşleme devam etmek isremisiniz");
                    bool islem = Convert.ToBoolean(Console.ReadLine());
                    if (islem == true)
                    {
                        Console.Clear();
                        goto go;
                    }
                    else
                    {
                        Console.WriteLine("BYE BYE");
                    }
                }
            }
            else { Console.WriteLine("O zaman teşekür ederiz"); }
            Console.ReadLine();
        }
    }
}
