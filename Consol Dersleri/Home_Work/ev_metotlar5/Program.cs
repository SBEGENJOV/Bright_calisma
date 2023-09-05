using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_metotlar5
{
    internal class Program
    {
        //araç seç, aracın fiyatına göre kdv ve ötv ekle
        static int menu()
        {
            Console.WriteLine("1-Audi");
            Console.WriteLine("2-Mercedez");
            Console.WriteLine("3-BMW");
            int secim=int.Parse(Console.ReadLine());
            
            switch(secim)
            {
                case 1:
                    Console.WriteLine("Seçtiginiz marka: Audi");
                    Console.WriteLine("Ödemeniz gereken tutar: "+tutarHesap());
                    break;
                case 2:
                    Console.WriteLine("Seçtiginiz marka: Mercedez");
                    Console.WriteLine("Ödemeniz gereken tutar: " + tutarHesap());
                    break;
                case 3:
                    Console.WriteLine("Seçtiginiz marka: BMW");
                    Console.WriteLine("Ödemeniz gereken tutar: " + tutarHesap());
                    break;
            }
            return secim;
        }
        static int tutarHesap()
        {
            Console.WriteLine("Arabanın tutarını gir: ");
            int tutar = int.Parse(Console.ReadLine());
            tutar += tutar * 15 / 100;
            return tutar;
        }
        static void Main(string[] args)
        {
            menu();
            Console.ReadLine();
        }
    }
}
