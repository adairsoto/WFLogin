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
    public partial class ClientScreen : Form
    {
        public ClientScreen()
        {
            InitializeComponent();
        }

        private void ClientScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.TextLength < 5)
            {
                btnLogin.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }
    }
}
