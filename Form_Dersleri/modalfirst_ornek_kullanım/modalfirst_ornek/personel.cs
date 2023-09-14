using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace modalfirst_ornek
{
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }
        Model1Container1 conn = new Model1Container1();
        private void button6_Click(object sender, EventArgs e)
        {
            plot std = new plot();
            std.plotName = textBox10.Text;
            std.plotAdres = textBox9.Text;
            std.plotPrice = int.Parse(textBox8.Text);
            std.plotM2 = int.Parse(textBox7.Text);
            std.customer_customerID = int.Parse(textBox12.Text);

            conn.plotSet.Add(std);
            conn.SaveChanges();
            dataGridView1.DataSource = conn.plotSet.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(textBox12.Text);
            var student = conn.plotSet.FirstOrDefault(s => s.plotID == sid);
            if (student != null)
            {
                student.plotName = textBox10.Text;
                student.plotAdres = textBox9.Text;
                student.plotPrice = int.Parse(textBox8.Text);
                student.plotM2 = int.Parse(textBox7.Text);
                student.customer_customerID = int.Parse(textBox6.Text);
                conn.SaveChanges();
                dataGridView1.DataSource = conn.plotSet.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(textBox12.Text);
            var plotDel = conn.plotSet.FirstOrDefault(s => s.plotID ==sid);
            conn.plotSet.Remove(plotDel);
            conn.SaveChanges();
            dataGridView1.DataSource = conn.plotSet.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource=conn.homeSet.ToList();
            }
            else if (comboBox1.SelectedIndex==1)
            {
                dataGridView1.DataSource = conn.plotSet .ToList();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = conn.customerSet.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home std = new home();
            std.homeName = textBox1.Text;
            std.homeAdres = textBox2.Text;
            std.homePrice = int.Parse(textBox3.Text);
            std.homeM2 = int.Parse(textBox4.Text);
            std.customer_customerID = int.Parse(textBox5.Text);

            conn.homeSet.Add(std);
            conn.SaveChanges();
            dataGridView1.DataSource = conn.homeSet.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(textBox6.Text);
            var student = conn.homeSet.FirstOrDefault(s => s.homeID == sid);
            if (student != null)
            {
                student.homeName = textBox10.Text;
                student.homeAdres = textBox9.Text;
                student.homePrice = int.Parse(textBox8.Text);
                student.homeM2 = int.Parse(textBox7.Text);
                student.customer_customerID = int.Parse(textBox5.Text);
                conn.SaveChanges();
                dataGridView1.DataSource = conn.homeSet.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(textBox11.Text);
            var homeDel = conn.homeSet.FirstOrDefault(s => s.homeID == sid);
            conn.homeSet.Remove(homeDel);
            conn.SaveChanges();
            dataGridView1.DataSource = conn.homeSet.ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customer std = new customer();
            std.customerName = textBox18.Text;
            std.customerAge =int.Parse(textBox17.Text);
            std.customerPhone =textBox16.Text;
            std.customerPW = textBox15.Text;

            conn.customerSet.Add(std);
            conn.SaveChanges();
            dataGridView1.DataSource = conn.customerSet.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(textBox14.Text);
            var student = conn.customerSet.FirstOrDefault(s => s.customerID == sid);
            if (student != null)
            {
                student.customerName = textBox18.Text;
                student.customerAge = int.Parse(textBox17.Text);
                student.customerPhone = textBox16.Text;
                student.customerPW = textBox15.Text;

                conn.SaveChanges();
                dataGridView1.DataSource = conn.customerSet.ToList();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(textBox14.Text);
            var cusDel = conn.customerSet.FirstOrDefault(s => s.customerID == sid);
            conn.customerSet.Remove(cusDel);
            conn.SaveChanges();
            dataGridView1.DataSource = conn.customerSet.ToList();
        }

        private void personel_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            this.Size = new System.Drawing.Size(760, 580);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox1.Location = new System.Drawing.Point(380, 350);
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox2.Location = new System.Drawing.Point(380, 350);
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox3.Location = new System.Drawing.Point(380, 350);
            }
        }
    }
}
