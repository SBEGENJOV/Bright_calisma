using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class ayakkabi
    {
        public int ayakkabıNo;
        public string marka;
        public string model;
        public int fiyat;
        public string tip;
        public string malzemeTuru;

        public void VeriAl()
        {
            Console.WriteLine("Ayakkabı No gir: ");
            ayakkabıNo=int.Parse(Console.ReadLine());
            Console.WriteLine("Ayakkabı Markası girin: ");
            marka=Console.ReadLine();
            Console.WriteLine("Ayakkabı modelini girin: ");
            model=Console.ReadLine();
            Console.WriteLine("Ayakkabı fiyatını girin: ");
            fiyat=int.Parse(Console.ReadLine());
            Console.WriteLine("Ayakkabı tipini gir: ");
            tip=Console.ReadLine();
            Console.WriteLine("Ayakkabı malzeme türünü gir: ");
            malzemeTuru=Console.ReadLine();
        }
        public void Yazdır()
        {
            Console.WriteLine("Ayakkabı No: "+ayakkabıNo);
            Console.WriteLine("Ayakkabı Markası: "+marka);
            Console.WriteLine("Ayakkabı Modeli: " + model);
            Console.WriteLine("Ayakkabı Fiyatı: " + KDV(fiyat));
            Console.WriteLine("Ayakkabı Tipi: " + tip);
            Console.WriteLine("Ayakkabı Malzemesi: " + malzemeTuru);
        }
        public int KDV(int fiyat)
        {
            fiyat += fiyat * 18 / 100;
            return fiyat;
        }
    }
}
