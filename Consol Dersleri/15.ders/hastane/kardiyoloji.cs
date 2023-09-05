using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane
{
    internal class kardiyoloji : poliklinik
    {
        public override int Kesinti(int maas)
        {
            maas -= maas * 10 / 100;
            return maas;
        }
        public override int Aylik(int Maas, int DonerSermaye)
        {
            Maas += Maas * DonerSermaye;
            Maas += 1000;
            return Maas;
        }
        public override void BasHemsire()
        {
            Console.WriteLine("Kardiyoloji bölümü hemşir Seyfettin bey");
        }

       
    }
}
