using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModelLayer.Model
{
    public class Birimler
    {
        [Key]
        public int BirimNO { get; set; }
        public string BirimAd { get; set; }
        public int BirimCalisanSayisi { get; set; }
        public int GorevNO { get; set; }
        [ForeignKey("GorevNO")]
        public Gorev Gorev { get; set; }
    }
}
