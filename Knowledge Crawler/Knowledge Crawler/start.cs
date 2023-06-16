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

            if (Settings.isFirst)
            {
                Settings.music = true;
                Settings.clickSfx = true;
                Settings.gameSfx = true;
                Settings.isFirst = false;
            }

            if (Settings.music)
                Settings.playBg();

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        private void playBtn_Click(object sender, EventArgs e)
        {
            Settings.playMenuSelect();
            Settings.stopBg();
            gameForm game = new gameForm();
            this.Hide();
            game.StartPosition = FormStartPosition.CenterParent;
            game.ShowDialog();
            this.Close();
        }

        private void guna2Shapes4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Environment.Exit(0);
        }

        private void guna2Shapes3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            Settings.playMenuSelect();
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

        private void start_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Settings.playMenuSelect();
            settingForm setting = new settingForm();
            setting.StartPosition = FormStartPosition.CenterParent;
            setting.ShowDialog();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADMIN USERNAME IS \"admin\" AND THE PASSWORD IS \"admin\"", "ADMIN LOGIN INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
