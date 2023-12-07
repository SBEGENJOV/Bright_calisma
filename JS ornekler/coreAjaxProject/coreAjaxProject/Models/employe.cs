using System.ComponentModel.DataAnnotations;

namespace coreAjaxProject.Models
{
    public class employe
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public decimal Salary { get; set; }
    }
}
