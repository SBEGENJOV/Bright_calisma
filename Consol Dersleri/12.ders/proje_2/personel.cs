using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{
    internal class personel
    {
        //field varsayılan erişim seviyesi privete
        public int personelNo;
        public string adSoyad;
        public int yas;
        public double maas;
        public double Prim;
        public string mesaiDurum;

        public double MaasTutar(double Maas, double prim, string mesaiDurum)
        {
            if (mesaiDurum=="evet")
            {
                maas *= prim;return maas;
            }
            else
            {
                maas += prim; return maas;
            }
        }
        public void Yardim(double maas)
        {
            Console.WriteLine("Evli misiniz");
            string medeniDurum=Console.ReadLine();
            if (medeniDurum=="evet")
            {
                maas += 1000;
                Console.WriteLine("Agi Tutar: " + maas);
            }
            else
            {
                Console.WriteLine("Maaş: " + maas);
            }
        }
    }
}
