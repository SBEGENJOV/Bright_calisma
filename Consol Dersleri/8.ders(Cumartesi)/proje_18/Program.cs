using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç isim girmek istersiniz: ");
            int deg=int.Parse(Console.ReadLine());
            string[] isimler = new string[deg];
            for(int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(i + 1 + ".İsimi gir: ");
                isimler[i] =Console.ReadLine();
            }
            for (int j =isimler.Length-1 ; j >=0; j--)
            {
                Console.WriteLine(j + 1 + ".Dizimizin elemanı: " + isimler[j]);
            }
            Console.ReadLine();
        }
    }
}
