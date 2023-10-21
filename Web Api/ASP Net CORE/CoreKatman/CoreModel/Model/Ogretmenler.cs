using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel.Model
{
    public class Ogretmenler
    {
        [Key]
        public int OgretmenID { get; set; }
        public string AdSoyad { get; set; }
        public decimal Maas { get; set; }
        public int DersID { get; set; }
        public Dersler Dersler { get; set; }
    }
}
