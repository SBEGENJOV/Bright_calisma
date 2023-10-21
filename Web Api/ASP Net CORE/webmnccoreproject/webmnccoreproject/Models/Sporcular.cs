using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webmnccoreproject.Models
{
    public class Sporcular
    {
        [Key]
        public int SporcuID { get; set; }
        public string AdSoyad { get; set; }
        public string Ulke { get; set; }
        public int TakimlarID { get; set; }
        [ForeignKey("TakimlarID")]
        public Takimlar Takimlar { get; set; }
    }
}
