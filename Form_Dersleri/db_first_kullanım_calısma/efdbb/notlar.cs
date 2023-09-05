using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace efdbb
{
    public partial class notlar : Form
    {
        public notlar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //orm(object relation mapping)
            //bir yazılımcının geliştirme için kullanılan terimdir oop yaklaşımını veritabanlarıyla ilişkilendirmek için kullanılır.
            //orm, geliştiricilerinin veritabanı işlemlerini daha kolay ve hızlı yapmasını ve anlaşılır şekilde işlemlerin yönetilmesine olanak sağlar. her bir tabloyu class, tablo içindeki kolonları ise field olarak degerlendirmek kodlama yapılmasına olanal sağlar.
            
            //Avantajları
            //daha hızlı ve daha kolay geliştirme.
            //dahA az  kodlama 
            //daha az hata 
            //veritabanı bagımsızlıgı
            //iyi performan

            //Dezavantajları
            //yüksek bellek tüketimi
            //ORM araçlarının karmaşıklıgı
            //daha yavaş veri çekme(ado.net e göre)
        }
    }
}
