using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sac=0,adet=0,top=0;
            Random rand = new Random();
            while (sac <= 10)
            {
                int say = rand.Next(100, 501);
                sac++;
                if (say%5==0 && say%7==0)
                {
                    adet++;
                    top += say;
                }
            }
            Console.WriteLine("5 ve 7 bölünenlerin toplam adeti: " + adet);
            Console.WriteLine("5 ve 7 bölünenlerin toplamı: " + top);
            Console.ReadLine();
        }
    }
}
