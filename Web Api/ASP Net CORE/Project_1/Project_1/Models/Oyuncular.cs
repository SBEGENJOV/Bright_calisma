using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_1.Models
{
    public class Oyuncular
    {
        [Key]
        public int OyuncuNo { get; set; }
        public string AdSoyad { get; set; }
        [DisplayName("Ücret")] //tabloda dörünen isim olmasını saglar
        public decimal Maas { get; set; }

        [ForeignKey("Dizi")]
        public int DiziNo { get; set; }
        public virtual Diziler Dizi { get; set; }
    }
}
