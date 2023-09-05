using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // || veya(or)
            go:
            Console.WriteLine("Kullanıcı adını giriniz: ");
            string Kullad=Console.ReadLine();
            if (Kullad == "admin" || Kullad == "Admin" || Kullad == "ADMIN") 
            {
                sifre:
                Console.WriteLine("Kullanıcı adı doğru şifre gir");
                Console.WriteLine("Lütfen şifrenizi giriniz: ");
                string Sifre=Console.ReadLine();
                if(Sifre =="1553")
                {
                    Console.WriteLine("Tebrikler şifre DOĞRU");
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
                bool islem=Convert.ToBoolean(Console.ReadLine());
                if (islem==true)
                {
                    Console.Clear();
                    goto go;
                }
                else
                {
                    Console.WriteLine("BYE BYE");
                }
            }
            Console.ReadLine();
        }
    }
}
