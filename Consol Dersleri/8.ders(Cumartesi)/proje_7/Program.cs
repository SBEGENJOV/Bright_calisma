using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int say1 = 0, say2 = 0, say3 = 0;
            int sac = 1,top=0;
            Random rand = new Random();
            while (sac!=4)
            {
                
                int say=rand.Next(1,3);
                if (say%2==0)
                {
                    if (sac==1)
                    {
                        say1 = say;
                    }
                    else if (sac == 2)
                    {
                        say2 = say;
                    }
                    else if (sac == 3)
                    {
                        say3 = say;
                    }
                    if (say1==say2)
                    {
                        Console.WriteLine("1.sayı ile 2.sayı aynı");
                    }
                    if (say2 == say3)
                    {
                        Console.WriteLine("2.sayı ile 3.sayı aynı");
                    }
                    if (say1 == say3)
                    {
                        Console.WriteLine("1.sayı ile 3.sayı aynı");
                    }
                    Console.WriteLine(sac+".Random çift sayı: " + say);
                    sac++;
                    top += say;
                }
            }
            Console.WriteLine("Sayıların toplamı: " + top);
            Console.ReadLine();
        }
    }
}
