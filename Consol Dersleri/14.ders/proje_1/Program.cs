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
            Console.WriteLine("1-Yazlık");
            Console.WriteLine("2-Kışlık");
            int durum=int.Parse(Console.ReadLine());
            if (durum==1)
            {
                yazlikAyakkabi yAyakkabi = new yazlikAyakkabi();
                yAyakkabi.yazlikYazdir();
            }
            else
            {
                 kislikAyakkabi kislikAyakkabi=new kislikAyakkabi();
                kislikAyakkabi.kislikYazir();
            }
            Console.ReadLine();
        }
    }
}
