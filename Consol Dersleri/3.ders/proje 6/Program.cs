using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fiyatı 200 tl den büyük olan ürünlere
            Console.WriteLine("Ürün fiyatını girin: ");
            float Fiyat=Convert.ToSingle(Console.ReadLine());
            if (Fiyat >=200)
            {
                float ZamUrun = (Fiyat / 100 * 50)+Fiyat;
                Console.WriteLine("Ürünün Son Fiyatı: " + ZamUrun);
                Console.WriteLine("Uygulanan Zam: " + (Fiyat / 100 * 50));
            }
            else
            {
                float YUrun = (Fiyat / 100 * 20)+Fiyat;
                Console.WriteLine("Ürünün Son Fiyatı: " + YUrun);
                Console.WriteLine("Uygulanan Zam: " + (Fiyat / 100 * 20));
            }
            Console.ReadLine();
        }
    }
}
