using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hediye sow = new hediye();
            sow.update();
            //sow.cek();
            sow.filtre();
            sow.add();
            sow.kampanya();
            int a = 1000;
           Console.WriteLine(sow.zam(a));
            Console.ReadLine();
        }
    }
}
