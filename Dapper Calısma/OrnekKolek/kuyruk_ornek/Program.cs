using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuyruk_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //queue (kuyruk) ilk giren ilk çıkar FİFO
            Queue kuyruk = new Queue();

            kuyruk.Enqueue(1);
            kuyruk.Enqueue("Ali");
            kuyruk.Enqueue("Veli");
            
            Console.WriteLine("kuyrukta "+ kuyruk.Count+ " sırada bekleyen var");
            Console.WriteLine("Kuyrukdat git "+ kuyruk.Dequeue()); //kuyruktan ilk elemanı çıkar.

            foreach (var item in kuyruk)
            {
                Console.WriteLine("Kuyruktakiler "+item);
            }

            Console.ReadLine();
        }
    }
}
