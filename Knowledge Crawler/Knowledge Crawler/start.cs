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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            gameForm game = new gameForm();
            this.Hide();
            game.StartPosition = FormStartPosition.CenterParent;
            game.ShowDialog();
            this.Close();
        }

        private void guna2Shapes4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Shapes3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            login log = new login(); ;
            log.StartPosition = FormStartPosition.CenterParent;
            if(log.ShowDialog() == DialogResult.OK)
            {
                admin ad = new admin();
                ad.StartPosition = FormStartPosition.CenterParent;
                this.Hide();
                ad.ShowDialog();
                this.Close();
            }
        }
    }
}
