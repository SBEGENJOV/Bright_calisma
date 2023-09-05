using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class Program
    {
        static int fiyat()
        {
            Console.WriteLine("Lütfen fiyat girin: ");
            int fiyatt = int.Parse(Console.ReadLine());
            return fiyatt;
        }
        static char erkekUrun(char Egiyim)
        {
            //Console.WriteLine("Lütfen giyim seçin: ");
            char giyimSecim = Egiyim;
            float ffiyat = fiyat();
            if (giyimSecim == 'a')
            {
                ffiyat += ffiyat * 3.5f / 100;
                Console.WriteLine("Ürün fiyatı: "+ffiyat);
                Console.WriteLine("Aksesuar istiyormusunuz: ");
                string cevap = Console.ReadLine();
                if (cevap == "evet")
                {
                    ffiyat += 500;
                    Console.WriteLine("Aksesuar fiyat eklenmiş hali: " + ffiyat);
                }
                else
                {
                    ffiyat += ffiyat * 2 / 100;
                    Console.WriteLine("Aksesuar fiyat eklenmemiş ama %2 kdv eklendi hali: " + ffiyat);
                }
            }
            if (giyimSecim == 'b')
            {
                ffiyat += ffiyat * 3.5f / 100;
                Console.WriteLine("Ürün fiyatı: " + ffiyat);
                Console.WriteLine("Aksesuar istiyormusunuz: ");
                string cevap = Console.ReadLine();
                if (cevap == "evet")
                {
                    ffiyat += 500;
                    Console.WriteLine("Aksesuar fiyat eklenmiş hali: " + ffiyat);
                }
                else
                {
                    ffiyat += ffiyat * 2 / 100;
                    Console.WriteLine("Aksesuar fiyat eklenmemiş ama %2 kdv eklendi hali: " + ffiyat);
                }
            }
            return giyimSecim;
        }
        static char kadınUrun(char Kgiyim)
        {
           // Console.WriteLine("Lütfen giyim seçin: ");
            char KgiyimSecim = Kgiyim;
            float ffiyat = fiyat();
            if (KgiyimSecim == 'a')
            {

                ffiyat += ffiyat * 3.5f / 100;
                Console.WriteLine("Ürün fiyatı: " + ffiyat);
                Console.WriteLine("Aksesuar istiyormusunuz: ");
                string cevap = Console.ReadLine();
                if (cevap == "evet")
                {
                    ffiyat += 500;
                    Console.WriteLine("Aksesuar fiyat eklenmiş hali: " + ffiyat);
                }
                else
                {
                    ffiyat += ffiyat * 2 / 100;
                    Console.WriteLine("Aksesuar fiyat eklenmemiş ama %2 kdv eklendi hali: " + ffiyat);
                }
            }
            if (KgiyimSecim == 'b')
            {
                ffiyat += ffiyat * 3.5f / 100;
                Console.WriteLine("Ürün fiyatı: " + ffiyat);
                Console.WriteLine("Aksesuar istiyormusunuz: ");
                string cevap = Console.ReadLine();
                if (cevap == "evet")
                {
                    ffiyat += 500;
                    Console.WriteLine("Aksesuar fiyat eklenmiş hali: " + ffiyat);
                }
                else
                {
                    ffiyat += ffiyat * 2 / 100;
                    Console.WriteLine("Aksesuar fiyat eklenmemiş ama %2 kdv eklendi hali: " + ffiyat);
                }
            }
            return KgiyimSecim;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Erkek giyim için -1- gir. Kadın giyim için -2- gir.");
            int secim=int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Dış giyim için -a- gir. İç giyim için -b- gir.");
                    char GsecimE = char.Parse(Console.ReadLine());
                    erkekUrun(GsecimE);
                    break;
                case 2:
                    Console.WriteLine("Dış giyim için -a- gir. İç giyim için -b- gir.");
                    char GsecimK = char.Parse(Console.ReadLine());
                    erkekUrun(GsecimK);
                    break;
                default:
                    fiyat();
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
