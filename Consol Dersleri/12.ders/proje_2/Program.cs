using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-İT");
            Console.WriteLine("2-İK");
            char departman=char.Parse(Console.ReadLine());

            if(departman == '1')
            {
                personel it = new personel();
                Console.WriteLine("Personel No gir: ");
                it.personelNo =int.Parse(Console.ReadLine());
                Console.WriteLine("Ad Soyad gir: ");
                it.adSoyad = Console.ReadLine();
                Console.WriteLine("Yas gir: ");
                it.yas = int.Parse(Console.ReadLine());
                Console.WriteLine("Maas gir: ");
                it.maas = int.Parse(Console.ReadLine());
                Console.WriteLine("Prim gir: ");
                it.Prim = int.Parse(Console.ReadLine());
                Console.WriteLine("Mesai gir: ");
                it.mesaiDurum = Console.ReadLine();
                double sonMaas = it.MaasTutar(it.maas, it.Prim, it.mesaiDurum);
                Console.WriteLine("Ad soyad: " + it.adSoyad);

                it.Yardim(sonMaas);
                Console.ReadLine();
                
            }
            else
            {
                personel ik = new personel();
            }
        }
    }
}
