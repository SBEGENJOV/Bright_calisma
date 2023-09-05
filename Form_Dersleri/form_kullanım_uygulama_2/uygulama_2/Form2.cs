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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void beşiktaşManavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anilManav anilmanav = new anilManav();
            anilmanav.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void şikayetVeTalepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            talep talep = new talep();
            talep.Show();
            this.Hide();
        }

        private void şişliManavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seyitManav seyitmanav = new seyitManav();
            seyitmanav.Show();
            this.Hide();
        }

        private void furkanManavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            furkanManav furkanmanav = new furkanManav();
            furkanmanav.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 formgeri = new Form1();
            formgeri.Show();
            this.Hide();
        }
    }
}
