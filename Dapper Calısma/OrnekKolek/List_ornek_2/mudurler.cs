using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_ornek_2
{
    internal class mudurler<T>
    {
        public int no;
        public string ad;

        public void Add(T deger)
        {
            Console.WriteLine("Deger Tipin: " + deger);
        }
    }
}
