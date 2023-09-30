using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuyruk_ornek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STACK (YIGIN) lifo
            //ilk giren ilk çıkar mantıgı
            //veri eklemek için pop kullanırız
            
            Stack depo=new Stack();
            depo.Push("1 mal");
            depo.Push("2 mal");
            depo.Push("3 mal"); 
            depo.Push("4 mal");
            depo.Push("5 mal");
            depo.Push("6 mal");

            Console.WriteLine("yıgıtdaki eleman sayısı " + depo.Count);

            Console.WriteLine("depodan çıkan mal "+ depo.Pop());

            foreach (var item in depo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Yıgındaki son eleman sayısı " + depo.Count);
            Console.ReadLine();
        }
    }
}
