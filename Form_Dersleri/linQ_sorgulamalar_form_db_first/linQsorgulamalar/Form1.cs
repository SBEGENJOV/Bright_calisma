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
    public partial class Form1 : Form
    {
        NorthwindEntities con=new NorthwindEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var query=from urunler in con.Urunlers
                      orderby urunler.HedefStokDuzeyi  
                      select urunler;
            dataGridView1.DataSource= query.ToList();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var query = from urunler in con.Urunlers
                        orderby urunler.HedefStokDuzeyi descending
                        select urunler;
            dataGridView1.DataSource = query.ToList();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var query=from mal in con.Urunlers
                      orderby mal.BirimFiyati descending
                      select mal;
            dataGridView1.DataSource = query.ToList();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var query = from urun in con.Urunlers
                        select new { urun.UrunAdi, urun.BirimFiyati, urun.HedefStokDuzeyi };
            dataGridView1.DataSource = query.ToList();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var query = from urun in con.Urunlers
                        where urun.BirimFiyati > 30 orderby urun.HedefStokDuzeyi descending
                        select new { urun.UrunAdi, urun.BirimFiyati, urun.HedefStokDuzeyi };
            dataGridView1.DataSource = query.ToList();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            var query = (from urun in con.Musterilers
                        where urun.Ulke == "Spain" && urun.Sehir=="Madrid"
                        select urun).Distinct();
            dataGridView1.DataSource = query.ToList();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            //var query = from urun in con.Musterilers
            //            where  urun.Sehir == textBox3.Text
            //            select urun;
            var query2 = con.Musterilers.Where(musteri => musteri.Sehir == textBox3.Text);
            dataGridView1.DataSource = query2.ToList();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            var query = from urun in con.Musterilers
                        where urun.Ulke == textBox1.Text && urun.Sehir==textBox2.Text
                        select urun;
            dataGridView1.DataSource = query.ToList();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            var query2 = con.Urunlers.Where(a => a.UrunAdi == "Côte de Blaye" && a.BirimFiyati>50);
            dataGridView1.DataSource = query2.ToList();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            var query2 = con.Urunlers.Where(a => a.BirimFiyati>20 && a.BirimFiyati < 50).OrderByDescending(a=>a.BirimFiyati);
            dataGridView1.DataSource = query2.ToList();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            DateTime datefirs=Convert.ToDateTime(textBox5.Text);
            DateTime datesecond = Convert.ToDateTime(textBox4.Text);
            //var query2 = con.Satislars.Where(a => a.OdemeTarihi > datefirs && a.OdemeTarihi < datesecond);

            var query = from date in con.Satislars
                        where date.OdemeTarihi > datefirs && date.OdemeTarihi < datesecond
                        orderby date.SatisID descending
                        group date by date.OdemeTarihi into grouped
                        select new
                        {
                            OdemeTarihi = grouped.Key
                        };

            dataGridView1.DataSource = query.ToList();
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            int ID=Convert.ToInt32(textBox1.Text);
            var query=(from x in con.Urunlers
                      where x.UrunID== ID
                      select x).FirstOrDefault();
            textBox2.Text = query.BirimFiyati.ToString();
            textBox3.Text = query.UrunAdi;


            var query1 = (from x in con.Urunlers
                         where x.UrunID == ID
                         select x);

            dataGridView1.DataSource=query1.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem!=null)
            {
                int ID = Convert.ToInt32(comboBox1.SelectedItem);
                var query=(from x in con.Urunlers
                where x.UrunID==ID
                select x).FirstOrDefault();

                textBox1.Text=query.BirimFiyati.ToString();
                textBox2.Text=query.UrunAdi;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var query = (from x in con.Urunlers
                         select new {x.HedefStokDuzeyi});
            comboBox2.DataSource=query.ToList();
            comboBox2.DisplayMember = "HedefStokDuzeyi";
            dataGridView1.DataSource= query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = (from mal in con.Urunlers
                         orderby mal.BirimFiyati descending
                         select mal).Take(3);
            dataGridView1.DataSource= query.ToList();
        }
    }
}
