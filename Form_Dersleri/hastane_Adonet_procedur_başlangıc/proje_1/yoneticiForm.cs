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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje_1
{
    public partial class yoneticiForm : Form
    {
        public yoneticiForm()
        {
            InitializeComponent();
        }

        public void listele()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "yoneticiListele";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
        }
        SqlConnection conn = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=hastane_otomasyon;Integrated Security=true;");

        

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "yoneticiEkle";
            command.Parameters.AddWithValue("yoneticiAdi", textBox1.Text);
            command.Parameters.AddWithValue("yoneticiSifre", textBox2.Text);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt eklendi");
            listele();
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["yoneticiAdi"].Value.ToString();
            textBox2.Text = satir.Cells["yoneticiSifre"].Value.ToString();
        }
        public void hastalistele()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "hastaListele";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView2.DataSource = filldata;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            hastalistele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hastaEkle";
            command.Parameters.AddWithValue("adSoyad", textBox4.Text);
            command.Parameters.AddWithValue("yas", textBox5.Text);
            command.Parameters.AddWithValue("boy", textBox6.Text);
            command.Parameters.AddWithValue("kilo", textBox7.Text);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt eklendi");
            hastalistele();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            textBox4.Tag = satir.Cells["hastaNo"].Value.ToString();
            textBox4.Text = satir.Cells["adSoyad"].Value.ToString();
            textBox5.Text = satir.Cells["yas"].Value.ToString();
            textBox6.Text = satir.Cells["boy"].Value.ToString();
            textBox7.Text = satir.Cells["kilo"].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hastaGuncelle";
            command.Parameters.AddWithValue("hastaNo", textBox4.Tag);
            command.Parameters.AddWithValue("adSoyad", textBox4.Text);
            command.Parameters.AddWithValue("yas", textBox5.Text);
            command.Parameters.AddWithValue("boy", textBox6.Text);
            command.Parameters.AddWithValue("kilo", textBox7.Text);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("hasta güncellendi");
            hastalistele();
        }

       

        private void button8_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hastAra";
            command.Parameters.AddWithValue("adSoyad", textBox4.Text);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView2.DataSource = filldata;
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hastaSil";
            command.Parameters.AddWithValue("hastaNo", textBox4.Tag);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Hasta Silindi");
            hastalistele();
        }

        private void yoneticiForm_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "doktorListele";
            conn.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read()) //true oldugu sürece çalışacak.
            {
                comboBox1.Items.Add(reader["polikilinikNo"]);
            }
            conn.Close();
        }
        public void doktorListele()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "doktorListele";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView3.DataSource = filldata;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            doktorListele();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "doktorEkle";
            command.Parameters.AddWithValue("dokAdSoyad", textBox10.Text);
            command.Parameters.AddWithValue("dokMaas", textBox9.Text);
            command.Parameters.AddWithValue("dokBolum", textBox8.Text);
            command.Parameters.AddWithValue("dokYas", textBox3.Text);
            command.Parameters.AddWithValue("polikilinikNo", comboBox1.Text);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt eklendi");
            doktorListele();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView3.CurrentRow;
            textBox10.Tag = satir.Cells["doktorNo"].Value.ToString();
            textBox10.Text = satir.Cells["dokAdSoyad"].Value.ToString();
            textBox9.Text = satir.Cells["dokMaas"].Value.ToString();
            textBox8.Text = satir.Cells["dokBolum"].Value.ToString();
            textBox3.Text = satir.Cells["dokYas"].Value.ToString();
            comboBox1.Text = satir.Cells["polikilinikNo"].Value.ToString();
            doktorListele();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "doktorGuncelle";
            command.Parameters.AddWithValue("doktorNo", textBox10.Tag);
            command.Parameters.AddWithValue("dokAdSoyad", textBox10.Text);
            command.Parameters.AddWithValue("dokMaas", textBox9.Text);
            command.Parameters.AddWithValue("dokBolum", textBox8.Text);
            command.Parameters.AddWithValue("dokYas", textBox3.Text);
            command.Parameters.AddWithValue("polikilinikNo", comboBox1.Text);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Doktor güncellendi");
            doktorListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "doktorAra";
            command.Parameters.AddWithValue("dokAdSoyad", textBox10.Text);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView3.DataSource = filldata;
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DoktorSil";
            command.Parameters.AddWithValue("doktorNo", textBox10.Tag);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Doktor Silindi");
            doktorListele();
        }

        public void polListele()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "polListele";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView4.DataSource = filldata;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            polListele();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "polEkle";
            command.Parameters.AddWithValue("polKapasite", textBox14.Text);
            command.Parameters.AddWithValue("polBasHemsire", textBox13.Text);
            command.Parameters.AddWithValue("polAdres", textBox12.Text);
            command.Parameters.AddWithValue("polCiro", textBox11.Text);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt eklendi");
            polListele();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView4.CurrentRow;
            textBox14.Tag = satir.Cells["polikilinikNo"].Value.ToString();
            textBox14.Text = satir.Cells["polKapasite"].Value.ToString();
            textBox13.Text = satir.Cells["polBasHemsire"].Value.ToString();
            textBox12.Text = satir.Cells["polAdres"].Value.ToString();
            textBox11.Text = satir.Cells["polCiro"].Value.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "polGuncelle";
            command.Parameters.AddWithValue("polikilinikNo", textBox14.Tag);
            command.Parameters.AddWithValue("polKapasite", textBox14.Text);
            command.Parameters.AddWithValue("polBasHemsire", textBox13.Text);
            command.Parameters.AddWithValue("polAdres", textBox12.Text);
            command.Parameters.AddWithValue("polCiro", textBox11.Text);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Poliklinik bilgileri güncellendi");
            polListele();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //polSil
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "polSil";
            command.Parameters.AddWithValue("polikilinikNo", textBox14.Tag);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Poliklinik Silindi");
            polListele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
