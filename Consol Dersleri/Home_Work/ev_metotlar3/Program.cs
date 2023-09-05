using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ev_metotlar3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] iller = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", 
            "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", 
            "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", 
            "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "İçel (Mersin)", "İstanbul", 
            "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", 
            "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", 
            "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", 
             "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", 
             "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };
            int sayac = 0;
            Console.WriteLine("Lütfen istediginiz değeri girin: ");
            string deger = Console.ReadLine();
                foreach (string il in iller)
                {
                    if (il.Contains(deger))
                    {
                        Console.WriteLine("Kelime içinde harfi bulundu." + il);
                        sayac++;
                        continue;
                    }
                    else { continue; }
                }
            if (sayac==0)
            {
                Console.WriteLine("Kelime içinde harfi bulunamadı.");
            }
            Console.ReadLine();
        }
    }
}
