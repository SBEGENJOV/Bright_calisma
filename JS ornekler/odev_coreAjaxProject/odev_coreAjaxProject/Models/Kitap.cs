using System.ComponentModel.DataAnnotations;

namespace odev_coreAjaxProject.Models
{
    public class Kitap
    {
        [Key]
        public int KitapID { get; set; }
        public string?  KitapAd { get; set; }
        public string? KitapYazar { get; set; }
        public int KitapYil { get; set; }
        public int KitapSayfa { get; set; }

    }
}
