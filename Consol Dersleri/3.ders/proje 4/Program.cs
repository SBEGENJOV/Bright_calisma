using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kiyafet adı
            //üretim yeri
            //cinsiyet türü
            //fiyat 200
            //indirim 50
            // kdv %18 uygulayıp ödediği tutarı gösteren program

            Console.WriteLine("Ürün adı gir : ");
            string Kiyafet = Console.ReadLine();
            Console.WriteLine("üretim yeri gir : ");
            string Üretim = Console.ReadLine();
            Console.WriteLine("Cinsiyetiniz nedir? : ");
            char Cinsiyet= Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ürün Fiyatı : ");
            float Fiyat= Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("İndirimi giriniz: ");
            float Indirim = Convert.ToSingle(Console.ReadLine());
            float IndirimliHali = (Fiyat - Indirim);
            float kdv = (Fiyat/100*18)+IndirimliHali;
            
            Console.WriteLine("Son fiyat: " + kdv);
            Console.ReadLine();



        }
    }
}
