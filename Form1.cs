using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = "admin";
            var pw = "admin";

            if (txtUser.Text == user && txtPassword.Text == pw)
            {
                ClientScreen clientScreen = new ClientScreen();
                clientScreen.ShowDialog();
            }
            else if (txtUser.Text != user)
            {
                MessageBox.Show("Wrong User", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
                txtUser.Clear();
                txtPassword.Clear();
            } 
            else
            {
                MessageBox.Show("Wrong Password", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                txtPassword.Clear();
            }
        }
    }
}
