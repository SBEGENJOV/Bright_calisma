using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornekKolek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList kisi = new ArrayList();
            Console.WriteLine("Kaç tane eleman eklemek istersiniz? ");
            int adet=int.Parse(Console.ReadLine());
            for(int i = 0; i < adet; i++)
            {
                Console.WriteLine("Kişi bilgleriniz girin");
                object a=Console.ReadLine();
                kisi.Add(a);
            }
            kisi.Remove(kisi[2]);
            foreach(var item in kisi)
            {
                Console.WriteLine("Kisi: "+item);

            }
            Console.ReadLine();
        }
    }
}
