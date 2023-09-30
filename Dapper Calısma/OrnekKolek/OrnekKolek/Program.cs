using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekKolek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Koleksiyonlar
            //c# dilinde verileri saklamak için kullanılan bir dizi gibi sabit veri yapılarından farklı olarak istege baglı dinamik olarak boyut kaplayan veri işlemlerimizi yapmamızı sağlar.

            //Koleksiyonlar 2 ye ayrılır.
            //1.Non-generic
            //2.Generic

            //koleksiyon çeşitleri
            //araylist (n)
            //sortedtable(n-g)
            //hastable(n)
            // queue(n-g)
            //stack(n-g)
            //list(g)
            //dictionary(g) v.b

            ArrayList ogrenci = new ArrayList();
            ogrenci.Add("Seyit");
            ogrenci.Add(24);
            ogrenci.Add("E");
            ogrenci.Add(104.5d);

            foreach (var i in ogrenci)
            {
                Console.WriteLine("Elemanlarımız: "+i);
            }
            Console.WriteLine(ogrenci[1]);
            Console.ReadLine();
        }
    }
}
