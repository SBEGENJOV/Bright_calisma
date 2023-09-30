using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_ornek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<hocalar> list = new List<hocalar>();
            list.Add(new hocalar("Seyit","Öğretmen",25));
            list.Add(new hocalar("Furkan", "E-Ticaret", 27));
            list.Add(new hocalar("Anıl", "Busnies", 24));

            foreach (var item in list)
            {
                Console.Write (item.adSoyad+" ");
                Console.Write (item.meslek + " ");
                Console.WriteLine (item.yas + " ");
            }
            personeller<hocalar> nesne= new personeller<hocalar>();
            personeller<mudurler> nesne1 = new personeller<mudurler>();


            Console.ReadLine();
        }
    }
}
