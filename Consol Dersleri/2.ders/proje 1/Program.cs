using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //c# da alınan tüm değerler string(metinsel)dir.(heap)
            //tam sayı için int kullanırım ama sbyte, tint de gelebilir(stek)
            // ondalıklılar için //
            // 1.float bazı sürümler sonuna f koy diyebilir,(stek) 
            //2.double bazı sürümler sonuna d koy diyebilir, (stek)
            //3.decimal bazı sürümler sonuna m koy diyebilir(stek)
            //bool değişken tipi true false 0,1 değerler alabilir.(stek)
            //char tek karekter alır.(stek)
            //object: tüm değişken ifadeleri kapsar.(heap)

            string NameSurname = "Seyitmuhammet Begenjov";
            string Meslek = "Öğretmen";
            int Toplam = 78;
            int Sayi = 5;
            Toplam = Toplam + Sayi; //Toplam+-/*=Sayi ikiside aynı sonucu verir

            Console.WriteLine("Toplam: "+Toplam);
            Console.ReadLine();//ekranda sabit bir şekilde kalmasını sağlıycak
        }
    }
}
