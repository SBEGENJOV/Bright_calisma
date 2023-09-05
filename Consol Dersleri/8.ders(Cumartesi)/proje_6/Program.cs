using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tum=" ";
            char say=' ';
            while (say!='i')
            {
                Console.WriteLine("Lütfen harf giriniz: ");
                say = char.Parse(Console.ReadLine());
                tum +=say;
            }
            Console.WriteLine("Girilen degerler: " + tum);
            Console.ReadLine();
        }
    }
}
