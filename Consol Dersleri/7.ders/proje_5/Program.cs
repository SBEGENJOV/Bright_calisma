using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int topm = 0;
            Random mesai = new Random();
            Console.WriteLine("Kaç çalışanın var: ");
            int csay=int.Parse(Console.ReadLine());
            for (int i = 1; i <= csay; i++)
            {
                Console.WriteLine(i+".Çalışanınızın maaşını girin:");
                int cmaas=int.Parse(Console.ReadLine());
                if (cmaas >=10000 && cmaas<=20000)
                {
                    Console.WriteLine("Kaç yılldır çalışıyor: ");
                    int cyil = int.Parse(Console.ReadLine());
                    if (cyil>=5 || cyil<=9)
                    {
                        int mmaas = mesai.Next(3500, 7000);
                        cmaas += mmaas;
                        Console.WriteLine(i + ".Çalışanınızın maaşı: " + cmaas);
                        topm += mmaas;
                    }
                    else
                    {
                        int mmaas1 = mesai.Next(2000, 3400);
                        cmaas += mmaas1;
                        Console.WriteLine(i + ".Çalışanınızın maaşı: " + cmaas);
                        topm += mmaas1;
                    }
                }
                else 
                {
                    int mmaas2 = mesai.Next(1000, 4000);
                    cmaas += mmaas2;
                    Console.WriteLine(i + ".Çalışanınızın maaşı: " + cmaas);
                    topm += mmaas2;
                }
            }
            Console.WriteLine("Toplam mesai maaşı: " + topm);
            Console.ReadLine();
        }
    }
}
