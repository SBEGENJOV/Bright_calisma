using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DAL;


namespace farmProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = gCrud.Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generation generation=new generation();
            generation.generationName = textBox2.Text;
            generation.generationYear = Convert.ToDateTime(dateTimePicker1.Text);
            generation.generationSeason = textBox3.Text;
            generation.generationPrice = Convert.ToInt32(textBox4.Text);
            generation.generationCity = textBox5.Text;
            generation.companyID = Convert.ToInt32(textBox6.Text);
            gCrud.Add(generation);
            dataGridView1.DataSource=gCrud.Listele();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            generation generation = new generation();
            generation.generationID = int.Parse(textBox1.Text);
            generation.generationName = textBox2.Text;
            generation.generationYear = Convert.ToDateTime(dateTimePicker1.Text);
            generation.generationSeason = textBox3.Text;
            generation.generationPrice = Convert.ToInt32(textBox4.Text);
            generation.generationCity = textBox5.Text;
            generation.companyID = int.Parse(textBox6.Text);
            //gCrud.Update(generation);
            if (!gCrud.Update(generation))
            {
                MessageBox.Show("olmadı");
            }
            dataGridView1.DataSource = gCrud.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generation generation = new generation();
            generation.generationID = int.Parse(textBox1.Text);
            gCrud.Delete(generation);
            dataGridView1.DataSource = gCrud.Listele();
        }
    }
}
