using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ders
{
    internal class kiyafet
    {
        public int kiyafeNo;
        public string kiyafetName;
        public int beden;
        public int olcu;//ölçü
        public int fiyat;
        public string marka;
        public string renk;

        public int Zam(int fiyat,string marka)
        {
            if (marka == "zara") 
            {
                fiyat += fiyat * 20 / 100;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }

        public void veriAl()
        {
            Console.WriteLine("Kıyafet No gir: ");
            kiyafeNo=int.Parse(Console.ReadLine());
            Console.WriteLine("Kıyafet Adı gir: ");
            kiyafetName=Console.ReadLine();
            Console.WriteLine("Beden girin: ");
            beden=int.Parse(Console.ReadLine());
            Console.WriteLine("Ölçü gir: ");
            olcu=int.Parse(Console.ReadLine());
            Console.WriteLine("Marka girin: ");
            marka=Console.ReadLine();
            Console.WriteLine("Renk girin: ");
            renk=Console.ReadLine();
            Console.WriteLine("Fiyat giriniz: ");
            fiyat=int.Parse(Console.ReadLine());
        }
        public void Yazdır()
        {
            Console.WriteLine("Kıyafet No : "+kiyafeNo);
            Console.WriteLine("Kıyafet adı : " + kiyafetName);
            Console.WriteLine("Beden : " + beden);
            Console.WriteLine("Ölçü : " + olcu);
            Console.WriteLine("Marka : " + marka);
            Console.WriteLine("Renk : " + renk);
            Console.WriteLine("Fiyat: " + fiyat);
        }
    }
}
