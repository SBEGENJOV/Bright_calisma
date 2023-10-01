using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcDapperProject.Models
{
    public class FirmaModel
    {
        public int FirmaNo { get; set; }
        public string FirmaAd  { get; set; }
        public decimal FirmaCiro { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
    }
}