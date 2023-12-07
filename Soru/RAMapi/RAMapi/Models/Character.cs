using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RAMapi.Models
{
    public class Character
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string gender { get; set; }
        public int originID { get; set; }
        [ForeignKey("ID")]
        public Origin origin { get; set; }
        public object location { get; set; }
        public string image { get; set; }    
        public Array episode { get; set; }    
        public string url { get; set; }    
        public string created { get; set; }    

    }
}
