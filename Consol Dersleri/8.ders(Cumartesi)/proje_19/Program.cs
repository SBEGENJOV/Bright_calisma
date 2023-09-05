using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int top=0,ort=0,sayac=0;
            int[] notlar= {40, 50, 100, 78};
            foreach (int say in notlar)
            {
                top += say;
                sayac++;
            }
            ort = top / notlar.Length;
            Console.WriteLine("Dizilerin eleman sayısı: " + sayac);
            Console.WriteLine("Sayıların toplamı: " + top);
            Console.WriteLine("Sayıların ortalaması: " + ort);
            Console.ReadLine();
        }
    }
}
