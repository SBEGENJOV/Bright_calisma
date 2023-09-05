using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while koşul kısımı doğru dönene kadar döngü dönecek,
            //ne zamanki döngü koşulu dogru olacak while kısımını çalıştırarak bitirecek.
            Console.WriteLine("Lütfen kaç isim gireceginizi girin: ");
            int say = int.Parse(Console.ReadLine());
            do 
            {
                Console.WriteLine(say);
                say++;
            } 
            while (say < 10);
            Console.WriteLine("Son alınan sayı: "+say);
            Console.ReadLine();
        }
    }
}
