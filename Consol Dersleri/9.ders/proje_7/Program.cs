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
            Console.WriteLine("Kaç şehir girmek istersiniz girin :");
            int ssay = int.Parse(Console.ReadLine()),sayac=0;
            string[] sehir =new string[ssay];
            //string[] sehir = {"Adana","İstanbul","İzmir","Bursa","Sivas", "Giresun", "Maraş", "Aydın", "Antep", "Manisa" };
            
            
            for (int i = 0; i < sehir.Length; i++)
            {
                Console.WriteLine("Şehir girin: ");
                string seh = Console.ReadLine();
                sehir[i] = seh;
                
            }
            Console.WriteLine("Aramak istediginiz değeri girin: ");
            string arama = Console.ReadLine();
            for (int i = 0; i < sehir.Length; i++)
            {
                if (sehir[i] == arama)
                {
                    sayac++;
                }
            }
            if (sayac == 1)
            {
                Console.WriteLine("Aradıgınız bulundu");
            }
            else
            {
                Console.WriteLine("Aranan şehir bulunamadı");
            }
            Console.ReadLine();
        }
    }
}
