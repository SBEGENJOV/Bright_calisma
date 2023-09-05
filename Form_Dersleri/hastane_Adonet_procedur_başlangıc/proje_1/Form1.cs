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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=hastane_otomasyon;Integrated Security=true;");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "selectkullanıcılar";
                cmd.Parameters.AddWithValue("kullanıcıAdi", textBox1.Text);
                cmd.Parameters.AddWithValue("kullanıcıSifre", textBox2.Text);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Hoşgeldiniz");
                    kullaniciForm go = new kullaniciForm();
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
            }
            if (radioButton2.Checked)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "selectyoneticiler";
                cmd.Parameters.AddWithValue("yoneticiAdi", textBox1.Text);
                cmd.Parameters.AddWithValue("yoneticiSifre", textBox2.Text);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Hoşgeldiniz");
                   yoneticiForm go = new yoneticiForm();
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
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            kayitEkran kayitgit = new kayitEkran();
            kayitgit.Show();
            this.Hide();
        }
    }
}
