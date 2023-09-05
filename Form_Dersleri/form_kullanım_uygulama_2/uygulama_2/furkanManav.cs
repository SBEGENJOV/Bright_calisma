using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_2
{
    public partial class furkanManav : Form
    {
        public furkanManav()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formgeri = new Form2();
            formgeri.Show();
            this.Hide();
        }
    }
}
