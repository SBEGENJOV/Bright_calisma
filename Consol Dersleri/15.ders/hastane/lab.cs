using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane
{
   sealed internal class lab : poliklinik
    {
        public string LabDurum;

        public override int Kesinti(int maas)
        {
            return 0;
        }
        //abstrack: kalıtım bırakmaya zorluyorduk.
        //sealed: kalıtım alabilir ama kalıtım bırakamaz. Nesne üretebilir.
    }
}
