using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linQsorgulamalar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        NorthwindEntities con =new NorthwindEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var query=con.Urunlers.Where(x=>x.UrunAdi=="Chai").Min(x=>x.BirimFiyati);
            textBox1.Text = query.ToString();
            //dataGridView1.DataSource = query.ToString();
            dataGridView1.DataSource =new List<string> { query.ToString() };
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var query = con.Urunlers.Where(x => x.UrunAdi == "Chai").Count();
            textBox1.Text = query.ToString();
            //dataGridView1.DataSource = query.ToString();
            dataGridView1.DataSource = new List<int> { query };
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var query = con.Musterilers.Where(m => m.Ulke == "spain").GroupBy(x => x.Sehir);
            dataGridView1.DataSource = query.ToList();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var query = from urun in con.Urunlers
                        group urun by urun.UrunAdi into gruplandir//group urun by urun.UrunAdi--gruplandırma yapılacak sütün adı=into gruplandir yapılan gruplandırmaya verilen isim
                        select new
                        {
                            urunAdi = gruplandir.Key,
                            toplamdeger = gruplandir.Sum(x => x.BirimFiyati)
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var query = from urun in con.Urunlers
                        group urun by urun.UrunAdi into gruplandir
                        select new
                        {
                            urunAdi = gruplandir.Key,
                            toplamdeger = gruplandir.Average(x => x.HedefStokDuzeyi)
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            var query = from urun in con.Urunlers
                        group urun by urun.UrunAdi into gruplandir
                        select new
                        {
                            urunAdi = gruplandir.Key,
                            toplamdeger = gruplandir.Max(x => x.HedefStokDuzeyi)
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            var query = from urun in con.Urunlers
                        group urun by urun.UrunAdi into gruplandir
                        select new
                        {
                            urunAdi = gruplandir.Key,
                            toplamdeger = gruplandir.Min(x => x.HedefStokDuzeyi)
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            var query = from personel in con.Personellers
                        join satis in con.Satislars on personel.PersonelID equals satis.PersonelID
                        select new
                        {
                            personel.Adi,
                            personel.SoyAdi,
                            satis.SatisTarihi,
                            satis.SevkAdi
                        };
            dataGridView1.DataSource=query.ToList();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            var query = from urun in con.Urunlers
                        join tedarik in con.Tedarikcilers on urun.TedarikciID equals     tedarik.TedarikciID where urun.BirimFiyati>50 && (urun.TedarikciID>5 && urun.TedarikciID<10)
                        select new 
                        {
                         urun.TedarikciID,
                         tedarik.MusteriAdi,
                         tedarik.Bolge,
                         urun.BirimFiyati
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            var query = from mus in con.Musterilers
                        join sat in con.Satislars on mus.MusteriID equals sat.MusteriID
                        join per in con.Personellers on sat.PersonelID equals per.PersonelID 
                        select new
                        {
                            mus.MusteriID,
                            mus.SirketAdi,
                            sat.SatisTarihi,
                            sat.SevkSehri,
                            per.Adi,
                            per.Unvan
                        };

            var query1 = from mus in con.Musterilers
                        join sat in con.Satislars on mus.MusteriID equals sat.MusteriID
                        join per in con.Personellers on sat.PersonelID equals per.PersonelID orderby sat.SatisTarihi descending 
                        select new
                        {
                            mus.MusteriID,
                            mus.SirketAdi,
                            sat.SatisTarihi,
                            sat.SevkSehri,
                            per.Adi,
                            per.Unvan
                        };
            dataGridView1.DataSource=query.ToList();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            var query = from per in con.Personellers
                        join sat in con.Satislars on per.PersonelID equals sat.PersonelID
                        group sat by per.Adi into perSatis
                        orderby (perSatis.Count()) descending
                        select new
                        {
                            perSatis = perSatis.Key,
                            toplamSatis = perSatis.Count()
                        };
            dataGridView1.DataSource=query.ToList();

        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            //satış tablosu-satişlar yılına göre toplam satışı gösteren linq sorgusu
            var query = from sat in con.Satislars
                        group sat by sat.SatisTarihi into satTar
                        orderby (satTar.Count()) descending
                        select new
                        {
                            satTar = satTar.Key,
                            satisOrtalama = satTar.Count()
                        };
            dataGridView1.DataSource=query.ToList();
                        
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            // ürünler ile satışlrı bir birine bağlanayan linq sorgusu
            var query = from ur in con.Urunlers
                        join sat in con.Satis_Detaylaris on ur.UrunID equals sat.UrunID
                        join satis in con.Satislars on sat.SatisID equals satis.SatisID
                        orderby ur.BirimFiyati
                        select new
                        {
                            ur.UrunAdi,
                            ur.BirimFiyati,
                            sat.UrunID,
                            sat.Miktar,
                            satis.SevkSehri,
                            satis.SevkUlkesi
                        };
            dataGridView1.DataSource=query.ToList();
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            //satış detaylar, urunler, kategoriler ve tedarikçileri bağlayan sorgu
            var query = from sat in con.Satis_Detaylaris
                        join ur in con.Urunlers on sat.UrunID equals ur.UrunID
                        join ted in con.Tedarikcilers on ur.TedarikciID equals ted.TedarikciID
                        join kat in con.Kategorilers on ur.KategoriID equals kat.KategoriID
                        orderby ted.SirketAdi descending
                        select new
                        {
                            sat.UrunID,
                            ur.UrunAdi,
                            ur.KategoriID,
                            ur.TedarikciID,
                            ted.SirketAdi,
                            kat.KategoriAdi
                        };
            dataGridView1.DataSource=query.ToList();
        }
    }
}
