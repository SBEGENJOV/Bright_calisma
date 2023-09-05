using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch case: else if gibi birden çok seçecek varsa kullanılabilir.
            //switch koşul yazar
            //case durumları kontrol edilir.(else if gibi)
            //default: varsayılan değer çalışır(else gibi)

            Console.WriteLine("Burç elementini gir: ");
            string burc=Console.ReadLine();
            switch (burc)
            {
                case "ateş":
                    Console.WriteLine("ali,akman");
                    Console.WriteLine("agu,bugu,cugu");
                    break;
                case "toprak":
                    Console.WriteLine("aylin,aynur");
                    Console.WriteLine("bugu,cugu");
                    break;
                case "su":
                    Console.WriteLine("senem,şahin");
                    Console.WriteLine("cugu,agu");
                    break;
                case "hava":
                    Console.WriteLine("seyit,tuba");
                    Console.WriteLine("cugu1,agu1");
                    break;
                default: 
                    Console.WriteLine("başka element yok ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
