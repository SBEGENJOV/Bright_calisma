using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace efdbb
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        BAUEntities conn=new BAUEntities();
        public bool loginUser(string userName, string passw)
        { 
            var query=from user in conn.Usersses where user.UserrName==userName && user.Password==passw
                      select user;
            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (loginUser(textBox1.Text, textBox2.Text))
            {
                EmployeePage go = new EmployeePage();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("agu bugu");
            }
        }
    }
}
