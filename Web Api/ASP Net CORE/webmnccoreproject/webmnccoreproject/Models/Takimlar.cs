using System.ComponentModel.DataAnnotations;

namespace webmnccoreproject.Models
{
    public class Takimlar
    {
        [Key]
        public int TakimlarID { get; set; }
        public string TakimAD { get; set; }
        public string Logo { get; set; }
    }
}
