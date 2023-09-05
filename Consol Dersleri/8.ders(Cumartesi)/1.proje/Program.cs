using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while- ne kadar tekrar edecegini bilmiyorsak kullanırız.
            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine(i+" .i değeri: "+i++);
            //}
            //Console.ReadLine();
            int i = 1,top=0;
            while (i<=100)
            {
                i++;
                if (i%2==0)
                {
                    top += i;
                }
            }
            Console.WriteLine("Çiftlerin toplamı: " + top);
            Console.ReadLine();
        }
    }
}
