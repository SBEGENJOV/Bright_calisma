using System.Collections.Generic;

namespace Core_Join.Models.ViewModels
{
	public class elemanDepListModel
	{
		public int DepartmanID { get; set; }
		public int ElemanID { get; set; }
		public List<Eleman> Eleman { get; set; }
		public List<Departman> Departmen { get; set; }
	}
}
