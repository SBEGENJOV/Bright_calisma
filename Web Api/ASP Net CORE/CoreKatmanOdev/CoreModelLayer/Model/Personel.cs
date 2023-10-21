using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModelLayer.Model
{
    public class Personel
    {
        [Key]
        public int PersonelNO { get; set; }
        public string PersonelAdSoyad { get; set; }
        public string PersonelCinsiyet { get; set; }
        public DateTime PersonelBTarih { get; set; }
        public string PersonelVardiyeDurum { get; set; }
        public int PersonelMaas { get; set; }
        public int PersonelPrim { get; set; }
        public int GorevNO { get; set; }
        [ForeignKey("GorevNO")]
        public Gorev Gorevs { get; set; }
        public int UnvanNO { get; set; }
        [ForeignKey("UnvanNO")]
        public Unvan Unvans { get; set; }
    }
}
