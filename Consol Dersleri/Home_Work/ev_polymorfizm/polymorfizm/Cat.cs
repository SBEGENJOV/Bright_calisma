using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfizm
{
    internal class Cat:animal
    {
        public Cat(String name)
        {
            this.name = name;
            this.sound = "Miyav Miyav";
            this.info = "Kedi";
        }
        public Cat(String name, String info)
        {
            this.name = name;
            this.sound = "Miyav Miyav";
            this.info = info;
        }
    }
}
