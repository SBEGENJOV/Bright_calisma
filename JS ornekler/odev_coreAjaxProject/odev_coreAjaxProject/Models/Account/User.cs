using System.ComponentModel.DataAnnotations;

namespace odev_coreAjaxProject.Models.Account
{
    public class User
    {
        [Key]
        public int kID { get; set; }
        public string kAd { get; set; }
        public string kSifre { get; set; }

    }
}
