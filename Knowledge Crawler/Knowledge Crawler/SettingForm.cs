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
    public partial class settingForm : Form
    {
        bool firstLoad = true;
        public settingForm()
        {
            InitializeComponent();
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
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (firstLoad)
                return;

            if (Settings.music)
                Settings.stopBg();
            else
                Settings.playBg();
            Settings.music = musicSwitch.Checked;
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            Settings.clickSfx = clickSwitch.Checked;
        }

        private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            Settings.gameSfx = gameSwitch.Checked;
        }

        private void settingForm_Load(object sender, EventArgs e)
        {
            musicSwitch.Checked = Settings.music;
            clickSwitch.Checked = Settings.clickSfx;
            gameSwitch.Checked = Settings.gameSfx;
            firstLoad = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Settings.playMenuSelect();
            this.Hide();
            this.Close();
        }
    }
}
