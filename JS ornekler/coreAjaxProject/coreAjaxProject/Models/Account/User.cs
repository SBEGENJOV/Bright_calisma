using System.ComponentModel.DataAnnotations;

namespace coreAjaxProject.Models.Account
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsRemember { get; set; }
    }
}
