using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _4.Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("taksimetre km giriniz");
            int tmetre=Convert.ToInt32(Console.ReadLine());
            if (tmetre>=1000 && tmetre<=2000)
            {
                Console.WriteLine("Taksimetre ücreti giriniz:");
                int ucret=Convert.ToInt32(Console.ReadLine());
                ucret += ucret * 10 / 100;
                Console.WriteLine("ödemeniz gereken tutar:"+ucret);
            }
            else
            {
                Console.WriteLine("Taksimetre ücreti giriniz: ");
                int ucter = Convert.ToInt32(Console.ReadLine());
                ucter += ucter * 30 / 100;
                Console.WriteLine("ödemeniz gereken tutar:" + ucter);
            }
            Console.ReadLine();
        }
    }
}
