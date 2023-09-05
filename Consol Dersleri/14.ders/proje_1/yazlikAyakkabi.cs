using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class yazlikAyakkabi:ayakkabi
    {
          string durum;
        public string aksesuarDurumu;
        public string renk;

        public string Durum
        {
            get { return durum; }
            set 
            {
                if (value=="açık" || value=="kapalı")
                {
                 durum = value; 
                }
                else
                {
                    Console.WriteLine("Girilen deger geçersiz");
                }
            }
        }
        public void yazlikVerial()
        {
            Console.WriteLine("Aksesuar alacakmısınız evet ise girin: ");
            aksesuarDurumu = Console.ReadLine();
            Console.WriteLine("Ayakkabı rengi gir: ");
            renk = Console.ReadLine();
        }
        public void yazlikYazdir()
        {

            
            VeriAl();
            yazlikVerial();
            Yazdır();
            Console.WriteLine("Ayakkabı durumu: "+Durum);
            Console.WriteLine("Ayakkabı rengi: " + renk);
            Console.WriteLine("Aksesuar : " + aksesuarDurumu);
        }
    }
}
