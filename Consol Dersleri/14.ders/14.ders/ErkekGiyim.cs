using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ders
{
    internal class ErkekGiyim:kiyafet
    {
        public string takimDurum;
        public int takımFiyat;
        public string aksesuar;

        public void Erkek()
        {
            veriAl();
            Yazdır();
            takimDurum = "Takım";
            takımFiyat = 1000;
            aksesuar = "Kravat";
            Zam(takımFiyat, marka);
        }
    }
}
