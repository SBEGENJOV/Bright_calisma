using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    //bakiye ye %10 fiaz
    internal class musteriler
    {
        //fieldlerin erişim belirteci otomatik olarak PRİVATE ollur.
        int musteriNo;
        private string adSoyad;
        string telNo;
        string mail;
        private int bakiye;
        public string adres;

        public int MusteriNo 
        {
            get 
            {
                return musteriNo;
            }
            set 
            {
                if (value == 4758)
                {
                    musteriNo = value;
                }
                else
                {
                    Console.WriteLine("Yalnış değer varsayılan numara atanacak");
                }
            }
        }

        public string AdSoyad
        {
            get
            {
                return adSoyad;
            }
            set
            {
                adSoyad = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }

        public string TelNo
        {
            get
            {
                return telNo;
            }
            set
            {
                if (value.Length==11)
                {
                    telNo = value;
                }
                else
                {
                    Console.WriteLine("Girilen deger 11 haneli olmadıgı için varsayılan değer atancak");
                }
            }
        }

        public int Bakiye
        {
            get
            {
                return bakiye;
            }
            set
            {
                if (value>100000 && value<500000)
                {
                    bakiye = value;
                }
                else
                {
                    Console.WriteLine("olumsuz bakiye");
                }
            }
        }

        public void yazdir()
        {
            Console.WriteLine("Müşteri No: " + MusteriNo);
            Console.WriteLine("Ad Soyad: " + AdSoyad);
            Console.WriteLine("Tel NO: " + TelNo);
            Console.WriteLine("Mail: " + Mail);
            Console.WriteLine("Bakiye: " + Bakiye);
        }

        public int vip(int vbakiye)
        {
            bakiye += bakiye * 10 / 100;
            return bakiye;
            
        }
    }
}
