using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //diziler
            //kullanımı int [] sayi(isimi)=new int[4]; --------------değer atanmamış hali
            //string [] isimler={"ali","veli","peki"}; --------------değer atanmış hali
            // new- varsa bellegin heep bölgesinde tutar(referans bölgesi)
            
            int[] yaslar=new int[5];
            //bellekte 5 elemanlı boş bir dizi tanımladık.
            yaslar[0] = 23;
            yaslar[1] = 24;
            yaslar[2] = 25;
            yaslar[3] = 26;
            yaslar[4] = 27;

            //foreach (int yas in yaslar)
            //{
            //    Console.WriteLine("Dizimizin elemanı: " + yas);
            //}
            for (int i = 0; i < yaslar.Length; i++)
            {
                Console.WriteLine(i+1+".Dizimizin elemanı: " + yaslar[i]);
            }
            Console.ReadLine();
        }
    }
}
