using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calismaORMModel
{
    public class Urunler
    {
        [Key]
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public string Barcode { get; set; }
        public double Fiyat { get; set; }
        public int KategotiID { get; set; }
        public string Resim { get; set; }

        [ForeignKey("KategotiID")]
        public Kategori Kategori { get; set; }
    }
}
