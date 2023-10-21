using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Lig1
    {
        [Key]
        public int LigID { get; set; }
        public string UlkeAd { get; set; }
        public string LigAd { get; set; }
        public string LigResim { get; set; }
        public int LigDeger { get; set; }
        public int LigIzleyciSay { get; set; }
        public int LigTakimSay { get; set; }
    }
}
