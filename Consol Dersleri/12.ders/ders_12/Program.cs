using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElektronikEsya elektronik=new ElektronikEsya();

            elektronik.marka = "Samsung";
            elektronik.model = "S8";
            elektronik.fiyat = 10000;
            elektronik.yil = 2023;
            elektronik.mensei = "Kore";

            //clas içerisindeki nesnelere nesne üreterek erişiyorum, üretmeden ulaşmak istersem STATİC kullanacam.
            Console.WriteLine("Elektronik marka: "+elektronik.model);
            Console.WriteLine("Elektronik fiyat: " + elektronik.fiyat);

            ElektronikEsya alet = new ElektronikEsya();
            Console.WriteLine("Marka adını girin:");
            alet.marka = Console.ReadLine();
            Console.WriteLine("MOdel adını girin:");
            alet.model = Console.ReadLine();
            Console.WriteLine("Fiyatı girin:");
            alet.fiyat =int.Parse(Console.ReadLine());
            Console.WriteLine("Yılı girin:");
            alet.yil = int.Parse(Console.ReadLine());
            Console.WriteLine("Mensei girin:");
            alet.mensei = Console.ReadLine();
            Console.WriteLine("Marka bilgisi: "+alet.marka);
            
           // int a= alet.kdv(alet.fiyat);
            Console.WriteLine("Fiyat 100 eklenmiş hali: " + alet.kdv(alet.fiyat));

            Console.ReadLine();
        }
    }
}
