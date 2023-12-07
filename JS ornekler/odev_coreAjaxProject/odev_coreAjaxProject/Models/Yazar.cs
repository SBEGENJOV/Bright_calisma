using System.ComponentModel.DataAnnotations;

namespace odev_coreAjaxProject.Models
{
    public class Yazar
    {
        [Key]
        public int YazarID { get; set; }
        public string? YazarAdSoyad { get; set; }
        public string? YazarMemleket { get; set; }
        public int YazarYas { get; set; }
        public int YazarKitapYaz { get; set; }
    }
}