using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane
{
    internal class dahiliye
    {
        int siraNo;
        string hastaIsim;

        public dahiliye(int siraNo, string hastaIsim)
        {
            this.siraNo = siraNo;
            this.hastaIsim = hastaIsim;
        }
      
        public dahiliye()
        {
            siraNo = 98;
            hastaIsim = "Agu";
        }
        ~dahiliye()//
        {
            Console.WriteLine("Yıkıcı metot çalıştı nesne silindi");
        }
    }
}
