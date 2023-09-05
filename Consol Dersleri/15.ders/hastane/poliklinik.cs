using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane
{
   abstract internal class poliklinik
    {
       int PolNo;
       public int CalısanSayısı;
       public string Aciklama;
       public int Maas;
       public int DonerSermaye;


        public int POlNO 
        {
            get { return PolNo; }
            set{ PolNo=value;  }
        }

        public virtual void BasHemsire()
        {
            Console.WriteLine("Hastenemizin Başhemşiresi, Emine Hanım");
        }

        public virtual int Aylik(int Maas, int DonerSermaye)
        {
            Maas += Maas + DonerSermaye;
            return Maas;
        }
        public abstract int Kesinti(int maas);

        public void Uyari()
        {
            Console.WriteLine("Çıkış saatinde uymayanların mmaşından kesinti olacaktır");
        }
    }
}
