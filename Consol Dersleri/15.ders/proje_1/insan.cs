using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class insan
    {
        public string AdSoyad;
        public int Yas;


        //Polyformizm metot tanımlama
        //Virtual(Sanal) metot tanımlıycaz ve methodun sanal olarak oldugunu düşünücez
        //ovverride yavru classlarda
        public virtual void SelamVer()
        {
            Console.WriteLine("Hello");
        }

        public virtual string Selam()
        {
            return "welcome";
        }
    }
}
