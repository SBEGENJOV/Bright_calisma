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
        {int[] say = {-99,-56,-78,-48,-78};
            for (int i = 0; i < 5; i++)
            {
                if (say[i]<0)
                {
                    
                    say[i] = say[i]*(-1);
                    Console.WriteLine("Neğatif gelen değer: " + say[i]);
                }
            }
            //for (int i = 0; i < say.Length; i++)
            //{
            //    Console.WriteLine("Dizi değelerim: " + say[i]);
            //}
            Console.ReadLine();
        }
    }
}
