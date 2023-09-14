using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            int sid = Convert.ToInt32(textBox1.Tag);
            student std = new student();
            var student = container.studentSet.FirstOrDefault(s => s.studentID ==sid);
            if (student!=null)
            {
                student.studentNameSurname = textBox1.Text;
                student.studentAge = int.Parse(textBox2.Text);
                student.studentPhone = textBox3.Text;
                student.studentAdres = textBox4.Text;
                student.teacherID = Convert.ToInt32(comboBox1.Text);
                container.SaveChanges();
                dataGridView1.DataSource = container.studentSet.ToList();
            }
            foreach(Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["studentID"].Value;
            textBox1.Text = satir.Cells["studentNameSurname"].Value.ToString();
            textBox2.Text = satir.Cells["studentAge"].Value.ToString();
            textBox3.Text = satir.Cells["studentPhone"].Value.ToString();
            textBox4.Text = satir.Cells["studentAdres"].Value.ToString();
            comboBox1.Text = satir.Cells["teacherID"].Value.ToString();
        }
    }
}
