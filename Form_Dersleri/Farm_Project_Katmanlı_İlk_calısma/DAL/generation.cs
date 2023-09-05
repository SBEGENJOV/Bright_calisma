using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class generation
    {
        public int generationID { get; set; }
        public string generationName { get; set; }
        public DateTime generationYear { get; set; }
        public string generationSeason { get; set; }
        public decimal generationPrice  { get; set; }
        public string generationCity { get; set; }
        public int companyID { get; set; }

    }
}
