using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModelLayer.Model
{
    public class Proje
    {
        [Key]
        public int ProjeNO { get; set; }
        public string ProjeAd { get; set; }
        public DateTime BaslamaTarih { get; set; }
        public DateTime BitisTarih { get; set; }
        public ICollection<Gorev> Gorevs { get; set; }
    }
}
