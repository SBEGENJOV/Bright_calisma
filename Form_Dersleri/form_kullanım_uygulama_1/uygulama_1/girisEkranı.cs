using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_1
{
    public partial class girisEkranı : Form
    {
        public girisEkranı()
        {
            InitializeComponent();
        }

        private void girisEkranı_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kAdi = textBox1.Text;
            int kSifre = int.Parse(textBox2.Text);

            if (kAdi=="admin" && kSifre==1234)
            {
                MessageBox.Show("Sayın: "+ kAdi+" Hoşgeldiniz");
                Form1 gec= new Form1();
                gec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yalnış bilgiler");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
