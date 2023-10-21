using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Takim1
    {
        [Key]
        public int TakimID { get; set; }
        public string TakimAd { get; set; }
        public string TakimResim { get; set; }
        public int TakimDeger { get; set; }
        public int TakimOyunSay { get; set; }
        public int LigID { get; set; }
        public Lig1 Lig { get; set; }
    }
}
