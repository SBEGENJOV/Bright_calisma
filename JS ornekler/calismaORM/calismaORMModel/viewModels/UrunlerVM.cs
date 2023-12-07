using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calismaORMModel.viewModels
{
    public class UrunlerVM
    {
        public Urunler Urunler{ get; set; }
        public IEnumerable<SelectListItem> KategoriList { get; set; }
    }
}
