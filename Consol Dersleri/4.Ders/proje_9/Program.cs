using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            don:
            Console.WriteLine("1-Samsung");
            Console.WriteLine("2-İphone");
            Console.WriteLine("3-Redmi");
            Console.WriteLine("Telefon markası seçiniz");
            int sec=Convert.ToInt32(Console.ReadLine());
            switch (sec)
            {
                case 1:
                    Console.WriteLine("Model Seçiniz: ");
                    Console.WriteLine("X-Galaxy");
                    Console.WriteLine("N-Note");
                    Console.WriteLine("T-Tablet");
                    char model=Convert.ToChar(Console.ReadLine());
                    switch (model)
                    {
                        case 'X':
                            Console.WriteLine("10.000 TL");
                            break;
                        case 'N':
                            Console.WriteLine("20.000 TL");
                            break;
                        case 'T':
                            Console.WriteLine("25.000 TL");
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("Model Seçiniz: ");
                    Console.WriteLine("X-14 pro");
                    Console.WriteLine("N-13 pro");
                    Console.WriteLine("T-12 pro");
                    char modelı = Convert.ToChar(Console.ReadLine());
                    switch (modelı)
                    {
                        case 'X':
                            Console.WriteLine("50.000 TL");
                            break;
                        case 'N':
                            Console.WriteLine("35.000 TL");
                            break;
                        case 'T':
                            Console.WriteLine("23.000 TL");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Model Seçiniz: ");
                    Console.WriteLine("X-Note");
                    Console.WriteLine("N-Fold");
                    Console.WriteLine("T-Tablet");
                    char modelr = Convert.ToChar(Console.ReadLine());
                    switch (modelr)
                    {
                        case 'X':
                            Console.WriteLine("15.000 TL");
                            break;
                        case 'N':
                            Console.WriteLine("40.000 TL");
                            break;
                        case 'T':
                            Console.WriteLine("20.000 TL");
                            break;
                    }
                    break;

                    default:
                    Console.WriteLine("tekrar denemek ister misiniz");
                    goto don;
                    break;
            }
            Console.ReadLine();
        }
    }
}
