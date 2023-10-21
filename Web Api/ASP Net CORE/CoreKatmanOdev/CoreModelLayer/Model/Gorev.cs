using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModelLayer.Model
{
    public class Gorev
    {
        [Key]
        public int GorevNO { get; set; }
        public string GorevTanimi { get; set; }
        public string GorevAd { get; set; }
        public int GorevPuan { get; set; }
        public ICollection<Proje> Projes { get; set; }

    }
}
