using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            yurtdisi yurtdisi = new yurtdisi();
            yurtici yurdici = new yurtici();
            Console.WriteLine("1-Yurtdışı");
            Console.WriteLine("2-Yurtiçi");
            int durum=int.Parse(Console.ReadLine());
            if(durum==1 )
            {
                yurtdisi.yazdir();

            }
            else
            {
             yurdici.yazdir();
            }
            Console.ReadLine();
        }
    }
}
