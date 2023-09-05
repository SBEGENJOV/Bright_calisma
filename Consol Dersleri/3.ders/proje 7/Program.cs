using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yaşınız Kaç:");
            int Yas=Convert.ToInt32(Console.ReadLine());
            if (Yas>=18)
            {
                Console.WriteLine("Maaşın Nedir: ");
                float Maas=Convert.ToSingle(Console.ReadLine());
                float ZamMaas = (Maas / 100 * 15) + Maas;
                Console.WriteLine("Çalışınca alacagım maaş: "+ZamMaas);
            }
            else
            {
                Console.WriteLine("Asgeri Ücret Ne Kadar: ");
                float AsgUcret=Convert.ToSingle(Console.ReadLine());
                float ZamMaas = (AsgUcret / 100 * 30);
                Console.WriteLine("Çalışınca alacagım maaş: " + ZamMaas);
            }
            Console.ReadLine();
        }
    }
}
