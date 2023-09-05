using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor
            // yapılandırıcıların görevi oluşturulan nesneyi ilk kullanıma hazırlamak eğer kullanıcı yada yazılımcı nesnelere değer ataması yapmadıysa 
            // o zaman yapılandırıcı metot varsayılan(default deger döner)
            
            //tanımlama kuralları 

            magaza magaza1 = new magaza(20,"Koton","Çocuk giyim");
            magaza magaza2 = new magaza(201, "Kotonn", "Çocukk giyim");
            //Console.WriteLine("Magaza NO:"+ magaza1.)
            Console.ReadLine();
        }
    }
}
