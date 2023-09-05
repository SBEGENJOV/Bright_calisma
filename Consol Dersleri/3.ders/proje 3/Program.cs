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
            //   +-/*
            //karşılaştırma yapmak için  sayac==20 
            //atama için ise = kullanılır
            //mod alma için ise % kullanılır
            //ve sembolu && & and yerine kullanalılır
            //veya sembolu || or yerine kullanılır 
            //birer şekilde artırmak için ++ kullanılır
            //eşit değilse için != kullanılır
            // < > <= >= kullanılabilir operatörler

            //c# da dışardan alınan değerlein hepsi string(metin) olarak gelir.
            //string tüm değerleri kapsar
            //+ ifadesi string kullandıgımızda birleştirme yapar.

            //c# da tüm değerler string olarak alındıgı için tür dönüşüm lazım bunun için
            //2 yöntem var  *convert, *parse kullanılır.
            //--------------------------------------------------------------------------------
            Console.WriteLine("Adınızı giriniz: ");
            //string NameSurname=Convert.ToString(Console.ReadLine());
            string NameSurname=Console.ReadLine();
            //Console.ReadLine():kullanıcıdan değer almak için
            Console.WriteLine("Yaşınızı giriniz: ");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayın " + NameSurname + " Yaşınız: " + age);

            //--------------------------------------------------------------------------------
            Console.WriteLine("Maas tutarınızı girin: ");
            float Pay=Convert.ToSingle(Console.ReadLine());
            //Single(float değer için kullanılır)
            Console.WriteLine("Prim tutarınızı girin: ");
            Double Prim =Convert.ToDouble(Console.ReadLine());
            Double ToplamMaas = Pay + Prim;
            Console.WriteLine("Cinsiyet giriniz E/K: ");
            Char Cinsiyet = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Cinsiyet: "+Cinsiyet);
            Console.WriteLine("Sayın "+NameSurname+" Toplam maaşınız: " + ToplamMaas);

            //string ToString
            //int    ToInt32
            //float  ToSingle()

            Console.ReadLine();
        }
    }
}
