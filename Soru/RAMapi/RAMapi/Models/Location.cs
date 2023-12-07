using System.ComponentModel.DataAnnotations;

namespace RAMapi.Models
{
    public class Location
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string dimension { get; set; }
        public Array residents { get; set; }
        public string url { get; set; }
        public string created { get; set; }
    }
}
