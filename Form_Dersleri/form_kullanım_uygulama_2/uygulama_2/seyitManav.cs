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
    public partial class seyitManav : Form
    {
        public seyitManav()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formgeri = new Form2();
            formgeri.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Sebze")
            {
                sebzeGroup.Visible = true;
                meyveGroup.Visible = false;
            }
            else if (comboBox1.Text == "Meyve")
            {
                meyveGroup.Visible = true;
                sebzeGroup.Visible = false;
            }
        }

        private void seyitManav_Load(object sender, EventArgs e)
        {
            sebzeGroup.Visible = false;
            meyveGroup.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
            if (comboBox1.Text == "Sebze")
            { 
                int fiyat = int.Parse(textBox1.Text);
                int kg = int.Parse(textBox2.Text);
                int tutar = fiyat * kg;
                MessageBox.Show("Ödemeniz gereken tutar: " + tutar);
                textBox1.Clear();
                textBox2.Clear();
            }
            else if (comboBox1.Text == "Meyve")
            {
                
                int fiyat = int.Parse(textBox3.Text);
                int kg = int.Parse(textBox4.Text);
                int tutar = fiyat * kg;
                MessageBox.Show("Ödemeniz gereken tutar: " + tutar);
                textBox3.Clear();
                textBox4.Clear();
            }
            
        }
    }
}
