using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_metotlar
{
    internal class Program
    {
        //static void adres()---------------parametresiz metot--------------------------
        //{
        //    string ad="Seyit ";
        //    string soyad = "Begenjov";
        //    Console.WriteLine(ad+soyad);
        //}
        //static void ad(string ad)-----parametreli metot----------------------------
        //{
        //    Console.WriteLine(ad);
        //}
        static void toplama(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("işlemlerin TOPLAMA: " + c);
        }
        static void cıkarma(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("işlemlerin ÇIKARMA: " + c);
        }
        static void bolme(int a,int b)
        {
            int c = a / b;
            Console.WriteLine("işlemlerin BÖLME: " + c);
        }
        static void carpma(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("işlemlerin ÇARPMA: " + c);
        }
        static void Main(string[] args)
        {
            //ad();-------1
            //string adim = "Seyitmuhammet";---2
            //ad(adim);------------------------2
            Console.WriteLine("Lütfen a degerini girin: ");
            int say1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen b degerini girin: ");
            int say2 = int.Parse(Console.ReadLine());
            toplama(say1,say2);
            cıkarma(say1, say2);
            bolme(say1, say2);
            carpma(say1, say2);
            Console.ReadLine();
        }
    }
}
