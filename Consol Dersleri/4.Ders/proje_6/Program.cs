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
            Random random = new Random();
            Console.WriteLine("1-Gömlek");
            Console.WriteLine("2-Pantolon");
            Console.WriteLine("3-Ayakkabı");
            int seceken = Convert.ToInt32(Console.ReadLine());
            if (seceken==1) 
            {
                Console.WriteLine("Kuponun varmı ? ");
                string kup=Console.ReadLine();
                if (kup == "evet")
                {
                    int secim1 = random.Next(500, 1001);
                    secim1 -= secim1 * 30 / 100;
                    
                    Console.WriteLine("Satın alım Online mi, Kapıdamı: ");
                    string ode=Console.ReadLine();
                    if(ode == "on")
                    {
                        secim1 += secim1 * 5 / 100;
                        Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    }
                    else
                    {
                        secim1 = secim1 * 20 / 100;
                        Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    }
                }
                else
                {
                    int secim1 = random.Next(500, 1001);
                    secim1 -= secim1 * 10 / 100;
                    Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    Console.WriteLine("Satın alım Online mi, Kapıdamı: ");
                    string ode = Console.ReadLine();
                    if (ode == "on")
                    {
                        secim1 += secim1 * 5 / 100;
                        Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    }
                    else
                    {
                        secim1 += secim1 * 20 / 100;
                        Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    }
                }
            }
            else if(seceken==2) 
            {
                Console.WriteLine("Kuponun varmı ? ");
                string kup = Console.ReadLine();
                if (kup == "evet")
                {
                    int secim1 = random.Next(500, 1001);
                    secim1 -= secim1 * 30 / 100;
                    Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    Console.WriteLine("Satın alım Online mi, Kapıdamı: ");
                    string ode = Console.ReadLine();
                    if (ode == "on")
                    {
                        secim1 += secim1 * 5 / 100;
                        Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    }
                    else
                    {
                        secim1 += secim1 * 20 / 100;
                        Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    }
                }
                else
                {
                    int secim1 = random.Next(500, 1001);
                    secim1 -= secim1 * 10 / 100;
                    Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    Console.WriteLine("Satın alım Online mi, Kapıdamı: ");
                    string ode = Console.ReadLine();
                    if (ode == "on")
                    {
                        secim1 += secim1 * 5 / 100;
                        Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    }
                    else
                    {
                        secim1 += secim1 * 20 / 100;
                        Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    }
                }
            }
            else if (seceken == 3)
            {
                Console.WriteLine("Kuponun varmı ? "); 
                string kup = Console.ReadLine();
                if (kup == "evet")
                {
                    int secim1 = random.Next(500, 1001);
                    secim1 -= secim1 * 30 / 100;
                    Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    Console.WriteLine("Satın alım Online mi, Kapıdamı: ");
                    string ode = Console.ReadLine();
                    if (ode == "on")
                    {
                        secim1 += secim1 * 5 / 100;
                        Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    }
                    else
                    {
                        secim1 += secim1 * 20 / 100;
                        Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    }
                }
                else
                {
                    int secim1 = random.Next(500, 1001);
                    secim1 -= secim1 * 10 / 100;
                    Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    Console.WriteLine("Satın alım Online mi, Kapıdamı: ");
                    string ode = Console.ReadLine();
                    if (ode == "on")
                    {
                        secim1 += secim1 * 5 / 100;
                        Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    }
                    else
                    {
                        secim1 += secim1 * 20 / 100;
                        Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
