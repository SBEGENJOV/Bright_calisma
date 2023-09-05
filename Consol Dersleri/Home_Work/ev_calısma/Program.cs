using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_calısma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Programa HOŞ GELDİNİZ");
                Console.WriteLine("İsim Giriniz:");
                string Name = Console.ReadLine();
                Console.WriteLine("Hangi Sınıftasınız: " + Name);
                string Sinif = Console.ReadLine();
                switch (Sinif)
                {
                    case "12a":
                        Console.WriteLine("Toplam net sayınız kaç");
                        int Net = Convert.ToInt32(Console.ReadLine()), Puan = 0;
                        Net += Net * 30 / 100;
                        Console.WriteLine("Sevgili " + Name + " Netiniz " + Net);
                        if (Net >= 0 && Net <= 30)
                        {
                            Puan = Net * 10;
                            Console.WriteLine("Sevgili " + Name + " Puanınız " + Puan);
                        }
                        else if (Net >= 31 && Net <= 50)
                        {
                            Puan = Net * 15;
                            Console.WriteLine("Sevgili " + Name + " Puanınız " + Puan);
                        }
                        else if (Net >= 51 && Net <= 80)
                        {
                            Puan = Net * 20;
                            Console.WriteLine("Sevgili " + Name + " Puanınız " + Puan);
                        }
                        else if (Net >= 81 && Net <= 100)
                        {
                            Puan = Net * 20;
                            Console.WriteLine("Sevgili " + Name + " Puanınız " + Puan);
                        }
                        else { Console.WriteLine("Geçerli bir değer giriniz!"); }
                        break;
                    case "12e":
                        Console.WriteLine("Toplam net sayınız kaç");
                        int Net1 = Convert.ToInt32(Console.ReadLine()), Puan1 = 0;
                        Net1 += Net1 * 25 / 100;
                        Console.WriteLine("Sevgili " + Name + " Netiniz " + Net1);
                        if (Net1 >= 0 && Net1 <= 30)
                        {
                            Puan = Net1 * 5;
                            Console.WriteLine("Sevgili " + Name + " Puanınız " + Puan1);
                        }
                        else if (Net1 >= 31 && Net1 <= 50)
                        {
                            Puan = Net1 * 10;
                            Console.WriteLine("Sevgili " + Name + " Puanınız " + Puan1);
                        }
                        else if (Net1 >= 51 && Net1 <= 80)
                        {
                            Puan = Net1 * 15;
                            Console.WriteLine("Sevgili " + Name + " Puanınız " + Puan1);
                        }
                        else if (Net1 >= 81 && Net1 <= 100)
                        {
                            Puan = Net1 * 20;
                            Console.WriteLine("Sevgili " + Name + " Puanınız " + Puan1);
                        }
                        else { Console.WriteLine("Geçerli bir değer giriniz!"); }
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Programda HATA ya rastlandı !");
            }
            finally 
            {
                Console.WriteLine("Program bitti, İyi günlr dilerim");
            }
            Console.ReadLine();
        }
    }
}