using System.ComponentModel.DataAnnotations;

namespace RAMapi.Models
{
    public class Episode
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string air_date { get; set; }
        public string episode { get; set; }
        public Array characters { get; set; }
        public string url { get; set; }
        public string created { get; set; }

    }
}
