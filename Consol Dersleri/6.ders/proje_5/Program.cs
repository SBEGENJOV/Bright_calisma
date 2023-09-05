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
            Console.WriteLine("Satıri gir:");
            int satir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sutunu gir:");
            int sutun= Convert.ToInt32(Console.ReadLine()),hesap=1;
            for (int i = 1; i <= sutun; i++)
            {
                hesap *=satir;
            }
            Console.WriteLine("sonuc: "+hesap);
            Console.ReadLine();
        }
    }
}
