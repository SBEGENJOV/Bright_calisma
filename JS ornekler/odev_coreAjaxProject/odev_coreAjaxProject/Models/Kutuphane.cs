using System.ComponentModel.DataAnnotations;

namespace odev_coreAjaxProject.Models
{
    public class Kutuphane
    {
        [Key]
        public int KutuphaneID { get; set; }
        public string? KutuphaneAd { get; set; }
        public string? KutuphaneKonum { get; set; }
        public int KutuphaneMasaSay { get; set; }
        public string? KutuphaneYonetici { get; set; }
    }
}
