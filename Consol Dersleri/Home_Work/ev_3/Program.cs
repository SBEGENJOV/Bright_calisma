using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç tane isim girmek istersiniz: ");
            int sac=int.Parse(Console.ReadLine());
            string[] deger = new string[sac];
            for (int i = 0; i < deger.Length; i++)
            {
                Console.WriteLine(i+1+".eleman için değer gir: ");
                deger[i] = Console.ReadLine();
            }
            for (int i = deger.Length-1;i >= 0;i--)
            {
                Console.WriteLine("eleman için değer gir: " + deger[i]);
            }
            Console.ReadLine();
        }
    }
}
