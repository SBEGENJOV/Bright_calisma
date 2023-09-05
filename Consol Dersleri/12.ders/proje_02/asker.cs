using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_02
{
    internal class asker
    {
        public int askerNo;
        public string adSoyad;
        public int yas;
        public string mezuniyet;
        public string memleket;
        public string meslek;
        public string donemBilgisi;
        //public double maas = 0;
        public int Maas(string mezuniyet)
        {
            int maas=0;
            if (mezuniyet=="lisans" || mezuniyet == "master")
            {
                maas += 5000;
                return maas;
            }
            else if (mezuniyet == "önlisans")
            {
                maas += 3000;
                return maas;
            }
            else 
            {
                maas += 1500;
                return maas;
            }
        }
        public int askerlik(int maas)
        {
            Console.WriteLine("Kaç gün askerlik yapacaksın: ");
            int gun=int.Parse(Console.ReadLine());
            
            if (maas>3000 && maas < 5000)
            {
                gun -= 20;
                return gun;
            }
            else if (maas > 1500 && maas < 3000 )
            {
                gun -= 15;
                return gun;
            }
            else {
                gun -= -5;
                return gun; 
                }
        }
        public void dmKontrol(double maas,int gun,string meslek, string donemBilgisi)
        {
            if (donemBilgisi == "uzun" && meslek == "muhendis")
            {
                maas += maas * gun;
                Console.WriteLine("Asker boyunca alacagınız ücret: " + maas);
            }
            else if (donemBilgisi == "kısa" && meslek == "muhendis")
            {
                maas += maas * gun / 2;
                Console.WriteLine("Asker boyunca alacagınız ücret: " + maas);
            }
        }
    }
}
