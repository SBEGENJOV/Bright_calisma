using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bas:
            en:
            int top = 1;
            Console.WriteLine("Kaçıncı sayı ile başlasın: ");
            int say1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç sayı ile işlem yapmak istiyorsunuız: ");
            int say=Convert.ToInt32(Console.ReadLine());
            try
            {
                if (say1 > say)
                {
                    goto bas;
                }
                for (int i = 1; say1 <= say; say1++)
                {
                    top = top * say;
                }
                Console.WriteLine("Sayıların toplamı: " + top);
            }
            catch 
            {
                Console.WriteLine("Hatalı işelem oldu, tekrar dene");
                goto en;
            }
            
            Console.ReadLine();
        }
    }
}
