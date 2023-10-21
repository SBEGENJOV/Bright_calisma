using System.ComponentModel.DataAnnotations;

namespace coreapiproject.Entity
{
    public class Takimlar
    {
        [Key]
        public int TakimlarID { get; set; }
        public string TakimAD { get; set; }
        public string Logo { get; set; }
    }
}
