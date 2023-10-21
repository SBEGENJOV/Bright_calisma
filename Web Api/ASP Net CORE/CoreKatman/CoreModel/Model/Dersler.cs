using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel.Model
{
    public class Dersler
    {
        [Key]
        public int DersID { get; set; }
        public string DersAd { get; set; }
        public ICollection<Ogrenciler> Ogrencilers { get; set; }
    }
}
