using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sesliharf = "aeiıoöüu",rakam = "1234567890", sesizharf= "bcçdfgğhjklmnprsştvyz";
            int sadet = 0,zadet=0,radet=0,okar=0;
            Console.WriteLine("Lütfen metin giriniz: ");
            string metin = Console.ReadLine();
            foreach (char karekter in metin)
            {
                foreach (char say in rakam)
                {
                    if (karekter == say)
                    {
                        radet++;
                    }
                }
                foreach (char sesizkar in sesizharf)
                {
                    if (karekter == sesizkar)
                    {
                        zadet++;
                    }
                }
                foreach (char seslikar in sesliharf)
                {
                    if (karekter == seslikar)
                    {
                        sadet++;
                    }
                }
            }
            Console.WriteLine("Metin uzunlugu: " + metin.Length);
            Console.WriteLine("Sesli karekter sayısı: " + sadet);
            Console.WriteLine("Sessiz karekter sayısı: " + zadet);
            Console.WriteLine("Rakam sayısı: " + radet);
            int ozelkarekter = metin.Length - (sadet + zadet + okar);
            Console.WriteLine("Özel karekter sayısı: " + ozelkarekter); 
            Console.ReadLine();
        }
    }
}
