using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfizm
{
    internal class animal
    {
        ///---> Değişken Tanımlamaları <---\\\
        public string name, sound, info, mark = new string('-', 6);
        public string getInfo
        {
            get { return info; }
        }

        ///---> Constructor Metot Tanımlamaları <---\\\
        public animal()
        {
            this.name = null;
            this.sound = null;
            this.info = null;
        }
        public animal(String name, String sound)
        {
            this.name = name;
            this.sound = sound;
            this.info = null;
        }
        public animal(String name, String sound, String info)
        {
            this.name = name;
            this.sound = sound;
            this.info = info;
        }
        ///---> Metot Tanımlaması <---\\\
        public void infoText()
        {
            Console.WriteLine("{0}\n < Hayvan Kimliği >\n{1}\n-> Türüm: {2}\n-> İsmim: {3}\n-> Çıkardığım Ses: {4}\n{5}", mark, mark, info, name, sound, mark);
        }
    }
}
