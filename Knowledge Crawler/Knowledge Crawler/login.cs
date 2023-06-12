using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_Crawler
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void guna2Shapes3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2Shapes4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(usernameTB.Text == "admin" && passwordTB.Text == "admin")
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please double check your spelling and capitalizations", "INCORRECT INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void passwordTB_IconRightClick(object sender, EventArgs e)
        {
            if (passwordTB.PasswordChar.ToString() == "●")
            {
                passwordTB.PasswordChar = '\0';
            }
            else
            {
                passwordTB.PasswordChar = '●';
            }
        }
    }
}
