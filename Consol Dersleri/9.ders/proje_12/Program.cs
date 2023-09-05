using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_12
{
    internal class Program
    {
        static void isim()
        {
            Console.WriteLine("Lütfen isim girin:");
            string isim=Console.ReadLine();
            Console.WriteLine(isim);
        }
        static void Main(string[] args)
        {
            isim();
            Console.ReadLine();
        }
    }
}
