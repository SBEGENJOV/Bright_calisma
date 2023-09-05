using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_1
{
    public partial class kayitEkran : Form
    {
        public kayitEkran()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=hastane_otomasyon;Integrated Security=true;");
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "kullanıcıEkle";
                command.Parameters.AddWithValue("kullanıcıAdi", textBox1.Text);
                command.Parameters.AddWithValue("kullanıcıSifre", textBox2.Text);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tebrikler Kullanıcı eklendi");
                kullaniciForm kgit = new kullaniciForm();
                kgit.Show();
                this.Hide();
            }
            if (radioButton2.Checked)
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "selectyoneticiler";
                command.Parameters.AddWithValue("yoneticiAdi", textBox1.Text);
                command.Parameters.AddWithValue("yoneticiSifre", textBox2.Text);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tebrikler Yönetici eklendi");
                kullaniciForm kgit = new kullaniciForm();
                kgit.Show();
                this.Hide();
            }
        }

        private void kayitEkran_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
