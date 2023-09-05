using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace proje_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] deger = new string[3];
            int say = 0,indis=0;
            for (int i = 0; i < deger.Length; i++)
            {
                Console.WriteLine("Lütfen değer girin: ");
                deger[i] = Console.ReadLine();
                if (deger[i].Length > say)
                {
                    say = deger[i].Length;
                    
                    indis = i;
                }
            }
            Console.WriteLine("En uzun değer: " + say);
            Console.WriteLine("En uzun değerin sırası: " + indis);
            Console.WriteLine("En uzun değerin sırası: " + deger[indis]);
            Console.ReadLine();

            //10 elemanlı random atanmış dizimiz 10 tane sayı(1-20 arasında) üretecek ve herbiri birbirinden farklı olacak.
            //iç içe for kullanılır
        }
    }
}
