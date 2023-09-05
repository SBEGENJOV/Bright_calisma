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
            //Tekrarlayan bir iş var ise döngüleri kullanırız;
            //başlangıç degeri, bitiş değeri, artış(azalma) degeri
            // Döngü çeşitleri //FOR,WHİLE,
            // DO-WHİLE:tek deger çalıştırmak için kullanıllır
            // FOREACH: listelemek için kullanılır
            Random rnd = new Random();
            for (int i = 1; i < 5; i++)
            {
                int say=rnd.Next(1,7);
                Console.WriteLine(i+".zar sonucu: "+say);
                //bitiş noktasına gelene kadar çalışır.
            }
            Console.ReadLine();
        }
    }
}
