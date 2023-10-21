using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel.Model
{
    public class Ogrenciler
    {
        [Key]
        public int OgrenciID { get; set; }
        public string AdSoyad { get; set; }
        public string Sinif { get; set; }
        public string KayitTarihi { get; set; }
        public DateTime Giris { get; set; }
        public ICollection<Dersler> Derslers { get; set; }//coka cok ilişkiler için yapılmasını saglar araya hangi tablolar ile baglı ise aracı yazıyoruz.
    }
}
