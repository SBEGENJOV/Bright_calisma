using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sporsalon sporsalon = new sporsalon();
            int ay = 10,fiyat=10000;

           int aidatt= sporsalon.aidat(ay, fiyat);
           int kam= sporsalon.zam(aidatt);
            Console.WriteLine(kam);
            sporsalon.kampanya(kam);
            sporsalon.uyeKontrol();
            cocukSporSalon cspor = new cocukSporSalon();
            cspor.uyarı();
            Console.ReadLine();

        }
    }
}
