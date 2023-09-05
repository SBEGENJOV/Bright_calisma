using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class fransizlar:insan
    {
        public override void SelamVer()
        {
            Console.WriteLine("bonjour");
        }
        public override string ToString()
        {
            return "bienvenue";
        }
    }
}
