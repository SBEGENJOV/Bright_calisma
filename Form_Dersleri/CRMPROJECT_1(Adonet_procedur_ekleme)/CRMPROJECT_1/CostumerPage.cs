using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//ado.net için kullanılan kütüphane

namespace CRMPROJECT_1
{
    public partial class CostumerPage : Form
    {
        public CostumerPage()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=CRM;Integrated Security=true;");
        public void listele()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "iselect";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
        }
        public void bosalt ()
            {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }


        private void CostumerPage_Load(object sender, EventArgs e)
        {
            textBox6.Visible = false;
            label6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType= CommandType.StoredProcedure;
            command.CommandText = "iAdd";
            command.Parameters.AddWithValue("costumerName", textBox1.Text);
            command.Parameters.AddWithValue("costumerSurname", textBox2.Text);
            command.Parameters.AddWithValue("costumerAge", textBox3.Text);
            command.Parameters.AddWithValue("costumerPhone", textBox4.Text);
            command.Parameters.AddWithValue("costumerMail", textBox5.Text);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt eklendi");
            listele();
            bosalt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "iUpdate";
            command.Parameters.AddWithValue("customerID", textBox1.Tag);
            command.Parameters.AddWithValue("costumerName", textBox1.Text);
            command.Parameters.AddWithValue("costumerSurname", textBox2.Text);
            command.Parameters.AddWithValue("costumerAge", textBox3.Text);
            command.Parameters.AddWithValue("costumerPhone", textBox4.Text);
            command.Parameters.AddWithValue("costumerMail", textBox5.Text);
            command.ExecuteNonQuery();
            conn.Close();
            listele();
            bosalt();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["customerID"].Value.ToString();
            textBox1.Text = satir.Cells["costumerName"].Value.ToString();
            textBox2.Text = satir.Cells["costumerSurname"].Value.ToString();
            textBox3.Text = satir.Cells["costumerAge"].Value.ToString();
            textBox4.Text = satir.Cells["costumerPhone"].Value.ToString();
            textBox5.Text = satir.Cells["costumerMail"].Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox6.Visible = true;
                label6.Visible = true;
            }
            else
            {
                textBox6.Visible = false;
                label6.Visible = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "idelete";
            command.Parameters.AddWithValue("customerID", textBox1.Tag);
            command.ExecuteNonQuery();
            conn.Close();
            listele();
            bosalt();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "iselectname";
            command.Parameters.AddWithValue("costumerName", textBox1.Text);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;


            command.ExecuteNonQuery();
            conn.Close();
            bosalt();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ifiltreage";
            command.Parameters.AddWithValue("costumerAge", textBox3.Text);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;


            command.ExecuteNonQuery();
            conn.Close();
            bosalt();
        }
    }
}
