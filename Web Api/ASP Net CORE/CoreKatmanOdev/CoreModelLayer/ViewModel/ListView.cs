using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModelLayer.ViewModel
{
    public class ListView
    {
        public int UnvanNO { get; set; }
        public string UnvanAd { get; set; }
        public int GorevNO { get; set; }
        public string GorevTanimi { get; set; }
        public string GorevAd { get; set; }
        public int GorevPuan { get; set; }
        public int BirimNO { get; set; }
        public string BirimAd { get; set; }
        public int BirimCalisanSayisi { get; set; }
        public int ProjeNO { get; set; }
        public string ProjeAd { get; set; }
        public DateTime BaslamaTarih { get; set; }
        public DateTime BitisTarih { get; set; }
        public int PersonelNO { get; set; }
        public string PersonelAdSoyad { get; set; }
        public string PersonelCinsiyet { get; set; }
        public DateTime PersonelBTarih { get; set; }
        public string PersonelVardiyeDurum { get; set; }
        public int PersonelMaas { get; set; }
        public int PersonelPrim { get; set; }
        public int CocukNO { get; set; }
        public string CocukAdSoyad { get; set; }
        public string CocukCinsiyet { get; set; }
        public DateTime CocukDogumTarih { get; set; }
    }
}
