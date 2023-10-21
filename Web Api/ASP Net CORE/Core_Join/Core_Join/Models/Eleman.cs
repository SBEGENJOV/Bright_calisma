using System.ComponentModel.DataAnnotations;

namespace Core_Join.Models
{
	public class Eleman
	{
		[Key]
        public int ElemanID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public string Adres { get; set; }
        public int DepartmanID { get; set; }
        public  Departman Departman { get; set; }
    }
}
