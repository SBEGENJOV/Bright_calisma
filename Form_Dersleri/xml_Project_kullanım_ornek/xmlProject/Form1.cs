using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace xmlProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Tedarikciler");

            SqlConnection conn = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS; database=Northwind;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand("select * from Tedarikciler", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                XmlElement tedarikci = xmlDocument.CreateElement("Tedarikci");
                XmlAttribute adres = xmlDocument.CreateAttribute("Adres");
                adres.Value = reader["Adres"].ToString();

                XmlAttribute sehir = xmlDocument.CreateAttribute("Sehir");
                sehir.Value = reader["Sehir"].ToString();

                XmlAttribute ulke = xmlDocument.CreateAttribute("Ulke");
                ulke.Value = reader["Ulke"].ToString();

                tedarikci.Attributes.Append(adres);
                tedarikci.Attributes.Append(sehir);
                tedarikci.Attributes.Append(ulke);
                root.AppendChild(tedarikci);
            }
            conn.Close();
            xmlDocument.AppendChild(root);
            xmlDocument.Save("veri.xml");
        }
    }
}
