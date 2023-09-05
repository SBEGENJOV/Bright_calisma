using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_2
{
    public partial class talep : Form
    {
        public talep()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            talepEkranı talepBilgi = new talepEkranı();
            talepBilgi.listBox1.Items.Add("Telefon No: "+maskedTextBox1.Text);
            talepBilgi.listBox1.Items.Add("Tarih: " + dateTimePicker1.Text);
            talepBilgi.listBox1.Items.Add("Talep ve Şikayet: " + textBox1.Text);

            talepBilgi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formgeri = new Form2();
            formgeri.Show();
            this.Hide();
        }
    }
}
