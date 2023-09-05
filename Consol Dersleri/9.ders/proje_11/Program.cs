using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_11
{
    internal class Program
    {
        static int turkp(int kur,int tutar)
        {
            kur = kur *tutar;
            return kur;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kuru girin: ");
            int kur = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen tutarı girin: ");
            int tutar = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen önce kuru sonra ise tutarı girin: "+turkp(kur,tutar));
            Console.ReadLine();
        }
    }
}
