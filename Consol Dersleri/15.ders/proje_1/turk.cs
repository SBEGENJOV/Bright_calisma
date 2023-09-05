using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class turk:insan
    {
        public override void SelamVer()
        {
            Console.WriteLine("Selamün Aleykmu");
        }
        public override string Selam()
        {
            return "Hoşgeldiniz";
        }
    }
}
