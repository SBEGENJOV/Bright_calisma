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
            yukari:
            Random random = new Random();
            Console.WriteLine("1-0 ile 2 yıl arasında ise 1 tıklayınız");
            Console.WriteLine("2-2 ile 3 yıl arasında ise 2 tıklayınız");
            Console.WriteLine("3-3 ile 5 yıl arasında ise 3 tıklayınız");
            Console.WriteLine("4-5 ile 10 yıl arasında ise 4 tıklayınız");
            Console.WriteLine("Garanti süresini giriniz: ");
            int seceken=Convert.ToInt32(Console.ReadLine());

            if(seceken == 1 ) 
            {
                Console.WriteLine("1.Seçenek çalıştı ");
                int secim1=random.Next(100,501);
                Console.WriteLine("Ödemeniz gereken tutar: " + secim1);
            }
            else if(seceken == 2 )
            {
                Console.WriteLine("2.Seçenek çalıştı ");
                int secim2 = random.Next(500, 751);
                Console.WriteLine("Ödemeniz gereken tutar: " + secim2);
            }
            else if (seceken == 3)
            {
                Console.WriteLine("3.Seçenek çalıştı ");
                int secim3 = random.Next(750, 901);
                Console.WriteLine("Ödemeniz gereken tutar: " + secim3);
            }
            else if (seceken == 4)
            {
                Console.WriteLine("4.Seçenek çalıştı ");
                int secim4 = random.Next(900, 1251);
                Console.WriteLine("Ödemeniz gereken tutar: "+secim4);
            }
            else 
            {
                Console.WriteLine("Hatalı girdiniz tekrar denemek ister misiniz ?");
            }
            bool sec = true;
            if (sec = true)
            {
                Console.Clear();
                goto yukari;
            }
            Console.ReadLine();
        }
    }
}
