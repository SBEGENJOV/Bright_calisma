using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace CRMPROJECT_1
{
    
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=CRM;Integrated Security=true;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            groupBox1 .Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Ulogin";
            cmd.Parameters.AddWithValue("usrerrName", textBox1.Text);
            cmd.Parameters.AddWithValue("userPassword", textBox2.Text);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(); 
            if (reader.Read())
            {
                MessageBox.Show("Hoşgeldiniz");
                CostumerPage go =new CostumerPage();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız");
                textBox1.Clear();
                textBox2.Clear();
            }
            conn.Close();
            //CostumerPage page = new CostumerPage();
            //page.Show();
            //this.Hide();

        }
    }
}
