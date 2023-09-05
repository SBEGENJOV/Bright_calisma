using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{
    internal class sporsalon : Iislem,Ihizmet

    {
        public int aidat(int ay, int fiyat)
        {
            if (ay>15 && ay < 500)
            {
                fiyat += 100;
                return fiyat;
            }
            return fiyat;
        }

        public void hizmetVer(int fiyat)
        {
            Console.WriteLine("Hizmetler...............");
        }

        public void kampanya(int fiyat)
        {
            if (fiyat>1000 && fiyat<2000)
            {
                Console.WriteLine("Sauna kazandınız");
            }
        }

        public void uyeKontrol()
        {
            Console.WriteLine("uyelik devam etsin mi");
            string durum= Console.ReadLine();
            if (durum == "evet")
            {
                Console.WriteLine("Kartınız aktif hizmetlerden yararlanabilirasiniz");
            }
            else
            {
                Console.WriteLine("üyrligin son 5 günü");
            }
        }

        public int zam(int fiyat)
        {
            fiyat += fiyat * 20 / 100;
            return fiyat;
        }
    }
}
