using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mezun durumu girin: ");
            string mezun = Console.ReadLine();
            asker ask=  new asker();
            Console.WriteLine("Melsek girin: ");
            string meslekk=Console.ReadLine();
            Console.WriteLine("Dönem girin: ");
            string donemm = Console.ReadLine();
            
            int maas=ask.Maas(mezun);
            int askerr = ask.askerlik(maas);
            ask.dmKontrol(maas,askerr,meslekk,donemm);

            Console.ReadLine();
        }
    }
}
