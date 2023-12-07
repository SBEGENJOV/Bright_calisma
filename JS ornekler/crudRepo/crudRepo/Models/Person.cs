using System.ComponentModel.DataAnnotations;

namespace crudRepo.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Display(Name = "Pin Code")]
        public int PinCode { get; set; }
        [Display(Name = "Active")]
        public bool IsActive { get; set; }

    }
}
