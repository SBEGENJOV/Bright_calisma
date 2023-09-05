using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int top = 0;
            int say=1;
            do
            {
                Console.WriteLine("sayı girin: ");
                say = int.Parse(Console.ReadLine());
                top += say;
            } while (say!=0);
            Console.WriteLine("Program biter 0 giedin");
            Console.WriteLine("sayıların toplamı: "+top);
            Console.ReadLine();
        }
    }
}
