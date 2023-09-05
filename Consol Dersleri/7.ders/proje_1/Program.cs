using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bak = 1;
            //int dak=Convert.ToInt32(Console.ReadLine());
            for (int i = 4; i <= 60; i+=4)
            {
                bak =bak*2;
            }
            Console.WriteLine("Bir saat sonraki bakteri sayısı: " + bak);
            Console.ReadLine();
        }
    }
}
