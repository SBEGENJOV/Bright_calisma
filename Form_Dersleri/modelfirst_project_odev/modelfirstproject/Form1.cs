using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modelfirstproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        schoolContainer container = new schoolContainer();
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource=container.teacherSet.ToList();
            comboBox1.ValueMember = "teacherID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=container.studentSet.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = container.studentSet.Where(a => a.studentNameSurname.ToLower().Contains(textBox1.Text) || a.studentNameSurname.ToUpper().Contains(textBox1.Text)).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            student std = new student();
            std.studentNameSurname = textBox1.Text;
            std.studentAge = int.Parse(textBox2.Text);
            std.studentPhone = textBox3.Text;
            std.studentAdres = textBox4.Text;
            std.teacherID = Convert.ToInt32(comboBox1.Text);

            container.studentSet.Add(std);
            container.SaveChanges();
            dataGridView1.DataSource=container.studentSet.ToList() ;


            foreach(Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
