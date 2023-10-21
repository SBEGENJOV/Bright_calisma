using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModelLayer.Model
{
    public class Cocuk
    {
        [Key]
        public int CocukNO { get; set; }
        public string CocukAdSoyad { get; set; }
        public string CocukCinsiyet { get; set; }
        public DateTime CocukDogumTarih { get; set; }
        public int PersonelNO { get; set; }
        [ForeignKey("PersonelNO")]
        public Personel Personel { get; set; }
    }
}
