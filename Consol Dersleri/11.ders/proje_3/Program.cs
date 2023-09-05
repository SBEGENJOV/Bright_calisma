using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_3
{
    internal class Program
    {
        static void menu()
        {
            Console.WriteLine("1-İlkokul");
            Console.WriteLine("2-lise");
            Console.WriteLine("3-Üniversite");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("1.yazılıyı gir: ");
                    int yazlı1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("2.yazılıyı gir: ");
                    int yazlı2 = int.Parse(Console.ReadLine());
                    notHesap(yazlı1, yazlı2);
                    break;
                case 2:
                    Console.WriteLine("1.yazılıyı gir: ");
                    int yazlı11 = int.Parse(Console.ReadLine());
                    Console.WriteLine("2.yazılıyı gir: ");
                    int yazlı22 = int.Parse(Console.ReadLine());
                    Console.WriteLine("1.Sözlüyü gir: ");
                    int sozlu1 = int.Parse(Console.ReadLine());
                    notHesap(yazlı11, yazlı22, sozlu1);
                    break;
                case 3:
                    Console.WriteLine("1.yazılıyı gir: ");
                    int yazlı111 = int.Parse(Console.ReadLine());
                    Console.WriteLine("1.Kaantı gir: ");
                    double kanat = double.Parse(Console.ReadLine());
                    notHesap(kanat, yazlı111);
                    break;
            }
        }
        static void notHesap(int yaz1,int yaz2)
        {
            double hesap = (yaz1 + yaz2)/2;
            Console.WriteLine("Not ortalamanız: " + hesap);
        }
        static void notHesap(int yaz1, int yaz2,int soz1)
        {
            double hesap = (yaz1 + yaz2+soz1) / 3;
            Console.WriteLine("Not ortalamanız: " + hesap);
        }
        static void notHesap(double kanat,int yaz1 )
        {
            double hesap = (yaz1 + kanat) / 2;
            Console.WriteLine("Not ortalamanız: " + hesap);
        }
        static void Main(string[] args)
        {
            //metotların aşırı yüklemsei
            //metot overloading
            //metotların aşırı yüklenmesi aynı metotların farklı şekillerde tanımlanarak farklı işlemlerde kullanılması demektir.
            //metot aynıdır ama parametreleri farklıdır.
            menu();
            Console.ReadLine();
        }
    }
}
