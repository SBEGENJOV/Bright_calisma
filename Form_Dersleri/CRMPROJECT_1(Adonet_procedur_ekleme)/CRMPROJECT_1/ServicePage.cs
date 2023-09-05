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
using System.Data.SqlClient;
namespace CRMPROJECT_1
{
    public partial class ServicePage : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=CRM;Integrated Security=true;");
        public ServicePage()
        {
            InitializeComponent();
        }

        private void ServicePage_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "serviceCostumer"; 
            conn.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read()) //true oldugu sürece çalışacak.
            {
                comboBox1.Items.Add(reader["customerID"]);
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
