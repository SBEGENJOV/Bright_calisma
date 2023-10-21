using System.ComponentModel.DataAnnotations;

namespace Core_Join.Models
{
	public class Departman
	{
		[Key]
		public int DepartmanID { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }

	}
}
