using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace efdbb
{
    public partial class EmployeePage : Form
    {
        public EmployeePage()
        {
            InitializeComponent();
        }
        BAUEntities conn=new BAUEntities();
        public void listele()
        {
            dataGridView1.DataSource = conn.Employees.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee employe=new Employee();
            employe.employeeNameSurname = textBox1.Text;
            employe.employeeAge = int.Parse(textBox2.Text);
            employe.empolyeeArdess = textBox3.Text;
            employe.employeePhone= textBox4.Text;
            conn.Employees.Add(employe);
            conn.SaveChanges();
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee employe = new Employee();
            int ID = Convert.ToInt32(textBox1.Tag);
            var deleteEmp = conn.Employees.Where(x => x.employeeID == ID).FirstOrDefault();

            conn.Employees.Remove(deleteEmp);
            conn.SaveChanges();
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee employe = new Employee();
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["employeeID"].Value.ToString();
            textBox1.Text = satir.Cells["employeeNameSurname"].Value.ToString();
            textBox2.Text = satir.Cells["employeeAge"].Value.ToString();
            textBox3.Text = satir.Cells["empolyeeArdess"].Value.ToString();
            textBox4.Text = satir.Cells["employeePhone"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee employe = new Employee();
            int ID=Convert.ToInt32(textBox1.Tag);
            var update=conn.Employees.Where(x=>x.employeeID==ID).FirstOrDefault();
            update.employeeNameSurname=textBox1.Text;
            update.employeeAge = int.Parse(textBox2.Text);
            update.empolyeeArdess = textBox3.Text;
            update.employeePhone = textBox4.Text;
            conn.SaveChanges();
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=conn.Employees.Where(x=>x.employeeNameSurname.Contains(textBox1.Text)).ToList();
        }
    }
}
