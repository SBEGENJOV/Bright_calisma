using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_odev_class
{
    internal class oyuncaklar
    {
        public string marka;
        public string model;
        public int fiyat;
        public string hediyecek;
        public string magizaAd;


        public void veriAl()
        {
            Console.WriteLine("Lütfen Marka girin: ");
            marka = Console.ReadLine();
            Console.WriteLine("Lütfen Model girin: ");
            model = Console.ReadLine();
            Console.WriteLine("Lütfen fiyat girin: ");
            fiyat=int.Parse(Console.ReadLine());
            Console.WriteLine("Hediye çekiniz varmı: ");
            hediyecek=Console.ReadLine();
            Console.WriteLine("Lütfen Magza adı girin: ");
            magizaAd = Console.ReadLine();
        }

        public void yazdir()
        {
            Console.WriteLine("Marka : " + marka);
            Console.WriteLine("Model : " + model);
            Console.WriteLine("Fiyat : " + fiyat);
            Console.WriteLine("Hediye çek durumu : " + hediyecek);
            Console.WriteLine("Magıza adı : " + magizaAd);
        }

        public int hesap(string marka,string model,int fiyat)
        {
            if (marka=="toyz")
            {
                if (hediyecek == "evet")
                {
                    fiyat -= fiyat * 10 / 100;
                    return fiyat;
                }
                else
                {
                    fiyat += fiyat * 2 / 100;
                    return fiyat;
                }
            }
            else if (marka == "barbie")
            {
                if (hediyecek == "evet")
                {
                    fiyat -= fiyat * 20 / 100;
                    return fiyat;
                }
                else
                {
                    fiyat += fiyat * 2 / 100;
                    return fiyat;
                }   
            }
            else
            {
                return fiyat;
            }
        }

        public void yaz()
        {
            veriAl();
            yazdir();
            Console.WriteLine("Ödemeniz gereken tutar:"+hesap(marka,model,fiyat));
            Console.ReadLine();
        }
    }
}
