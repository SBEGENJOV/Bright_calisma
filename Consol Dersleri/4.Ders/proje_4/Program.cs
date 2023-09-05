using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random değer atama(rastgele sayı üretmek için kullanılan komuttrur).
            Random rastgele=new Random();
            int sayi=rastgele.Next(0,3);
            Console.WriteLine(sayi);
            Console.WriteLine("GS ve FB maç sonucu: ");
            if(sayi==0) 
                {
                Console.WriteLine("MAÇ BERABERE");
                }
            else if(sayi==1) 
                { 
                Console.WriteLine("MAÇ GS nin"); 
                }
            else 
                { 
                Console.WriteLine("MAÇ FB nin"); 
                }
            Console.ReadLine();


        }
    }
}
