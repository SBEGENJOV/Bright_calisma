using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kontrol ve koşul mekanızma if ve else ile olur
            // sayaç==20
            //yaş>18
            //if (Sayac==20) 
            //{
            ////koşul doğru ise çalışır
            //}

            //else 
            //{
            // //koşul doğru değilse ise çalışır
            //}

            Console.WriteLine("Sigorta prim gün sayısı giriniz: ");
            int PrimGun=Convert.ToInt32(Console.ReadLine());
            if (PrimGun>=7200) 
            {
                Console.WriteLine("EYT li oldun");
                
            }
            else 
            {
                Console.WriteLine("Daha bekle");
                int KalanGun = 7200 - PrimGun;
                Console.WriteLine("Galan gün : "+KalanGun);
            }
            Console.WriteLine("Yine Beklerük");
            Console.ReadLine();
        }
    }
}
