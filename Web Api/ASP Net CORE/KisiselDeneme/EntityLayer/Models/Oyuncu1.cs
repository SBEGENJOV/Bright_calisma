using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Oyuncu1
    {
        [Key]
        public int OyuncuId { get; set; }
        public string OyuncuAd { get; set; }
        public string OyuncuMevki { get; set; }
        public string OyuncuResim { get; set; }
        public string OyuncuYas { get; set; }
        public int TakimID { get; set; }
        public Takim1 Takim { get; set; }
    }
}
