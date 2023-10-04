using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcProject.Models
{
    public class mvcDavaModel
    {
        public int DavaNo { get; set; }
        public string DavaAdi { get; set; }
        public string DosyaNo { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }
        public string AdliyeAdi { get; set; }
        public string AdliyeAdres { get; set; }
        public string DavaTipi { get; set; }
        public bool Durum { get; set; }
    }
}