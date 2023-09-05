using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach: liste ve dizi elemanları arasında verileri tek tek göstermek için kullanılan döngüdür.

            string harf = "seuyrurofrotvnmbjglsli";
            string rakam = "54864564";
            foreach (char metin in harf)
            {
                Console.WriteLine("karekter değerlerim: " + metin);
            }
            foreach (char karekter in rakam)
            {
                Console.WriteLine("karekter değerlerim: "+karekter);
            }
            Console.ReadLine();
        }
    }
}
