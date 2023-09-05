using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dizinin içerisine kullanıcıdan gelen değerlerle doldur

            int [] sayilar =new int[4];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(i + 1 + ".Dizimizin elemanını gir: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            //doldurmuş oldugumuz dizinin elemanlarını görmek istersek.
            for (int i = 0;i < sayilar.Length; i++)
            {
                Console.WriteLine(i + 1 + ".Dizimizin elemanı: " + sayilar[i]);
            } 
            Console.ReadLine();
        }
    }
}
