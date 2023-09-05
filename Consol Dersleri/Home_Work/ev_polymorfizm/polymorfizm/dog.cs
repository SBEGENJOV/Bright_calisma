using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfizm
{
    internal class dog:animal
    {
        public dog(String name)
        {
            this.name = name;
            this.sound = "Hav Hav";
            this.info = "Köpek";
        }
        public dog(String name, String info)
        {
            this.name = "agu";
            this.info = info;
            this.sound = "Hav Hav";
        }
    }
}
