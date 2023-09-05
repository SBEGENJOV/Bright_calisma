using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do while yapısı ise ilk do'dan işleme başladıgı için ilk do blogunun içerisini çalıştırır.
            //do
            //{
            //    //işlemler
            //} while (koşul);
            string kulad,sifre;

            do
            {
                Console.WriteLine("kullanıcı adı girin: ");
                kulad = Console.ReadLine();
                Console.WriteLine("şifre girin: ");
                sifre = Console.ReadLine();
            } while (kulad!="admin" || sifre!="1234");
            Console.WriteLine("İşlem başarılı :)");
            Console.ReadLine();
        }
    }
}
