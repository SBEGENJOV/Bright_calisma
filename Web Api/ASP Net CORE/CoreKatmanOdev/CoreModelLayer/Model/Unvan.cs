using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModelLayer.Model
{
    public class Unvan
    {
        [Key]
        public int UnvanNO { get; set; }
        public string UnvanAd { get; set; }
    }
}
