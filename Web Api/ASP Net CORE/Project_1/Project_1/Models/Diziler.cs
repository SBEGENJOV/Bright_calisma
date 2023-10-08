using System.ComponentModel.DataAnnotations;

namespace Project_1.Models
{
    public class Diziler
    {
        [Key]
        public int diziNo { get; set; }
        [Required]
        [StringLength(25)]
        public string Ad { get; set; }

        [Required]
        [Range(1000,5000,ErrorMessage ="Aralık Dışı")]
        public decimal Sermaye { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Aralık Dışı")]
        public int CalisanSayisi { get; set; }

        [Required]
        [StringLength(25)]
        public string Yetkili { get; set; }
    }
}
