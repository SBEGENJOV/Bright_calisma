using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] sayi = new int[10];
            int nsayac = 0, psayac = 0, negsayac = 0, top = 0;
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine("Lütfen sayı girin: ");
                sayi[i] = int.Parse(Console.ReadLine());
                if (sayi[i] == 0)
                {
                    nsayac++;
                    Console.WriteLine("Nötr sayı: " + sayi[i]);
                }
                else if (sayi[i] < 0)
                {
                    negsayac++;
                    Console.WriteLine("Negatif sayı: " + sayi[i]);
                }
                else
                {
                    Console.WriteLine("Pozitif sayı: " + sayi[i]);
                    psayac++;
                }
            }
            Console.WriteLine("Nötr sayı: " + nsayac);
            Console.WriteLine("Nötr sayı: " + negsayac);
            Console.WriteLine("Nötr sayı: " + psayac);
            Console.ReadLine();
        }
    }
}
