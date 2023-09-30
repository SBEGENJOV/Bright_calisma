using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<bool> list = new List<bool>();
            list.Add(true);
            list.Add(true);
            list.Add(false);
            list.Add(true);

            foreach (bool item in list)
            {
                Console.WriteLine(item);
            }

            //binary search: kendine verilen degerin kaçıncı sırada oldugunu gösterer.
            int deger = list.BinarySearch(false);


            Console.ReadLine();
        }
    }
}
