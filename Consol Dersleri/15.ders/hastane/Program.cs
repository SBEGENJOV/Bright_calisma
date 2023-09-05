using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kardiyoloji kardiyolojii = new kardiyoloji();
            Console.WriteLine("Maaş giriniz: ");
            kardiyolojii.Maas=int.Parse(Console.ReadLine());
            Console.WriteLine("Döner sermaye giriniz: ");
            kardiyolojii.DonerSermaye = int.Parse(Console.ReadLine());
            kardiyolojii.Uyari();
            kardiyolojii.BasHemsire();
            int Ktutar = kardiyolojii.Aylik(kardiyolojii.Maas, kardiyolojii.DonerSermaye);
            Console.WriteLine("Kardiyoloji maaş: " + kardiyolojii.Kesinti(Ktutar));
            //----------------------------------------------------------
            ortopedi ortopedi = new ortopedi();
            Console.WriteLine("Ortopedi maaşı giriniz: ");
            ortopedi.Maas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ortopedi döner sermaye giriniz: ");
            ortopedi.DonerSermaye = int.Parse(Console.ReadLine());
            ortopedi.Uyari();
            ortopedi.BasHemsire();
            int Otutar = ortopedi.Aylik(ortopedi.Maas, ortopedi.DonerSermaye);
            Console.WriteLine("Ortopedi maaş: " + ortopedi.Kesinti(Otutar));
            //-----------------------------------------------------------
            dahiliye dahiliye1  = new dahiliye();
            Console.WriteLine("Dahiliye hasta no: "+dahiliye1.siraNO);
            Console.WriteLine("Dahiliye hasta Ad: " + dahiliye1.hastaIsiM);
            Console.ReadLine();
        }
    }
}
