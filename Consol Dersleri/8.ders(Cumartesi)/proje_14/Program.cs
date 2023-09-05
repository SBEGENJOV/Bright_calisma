using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sesliharf = "aeiıoöüu";
            int adet = 0;
            Console.WriteLine("Lütfen metin giriniz: ");
            string metin=Console.ReadLine();
            foreach (char karekter in metin)
            {
                foreach (char sharf in sesliharf)
                {
                    if (karekter ==sharf)
                    {
                        adet++;
                    }
                }
            }
            Console.WriteLine("Toplam eşlesen harf sayısı: " + adet);
            Console.WriteLine("Metin uzunlugu: " + metin.Length);
            Console.ReadLine();
        }
    }
}
