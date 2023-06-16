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

namespace Knowledge_Crawler
{
    public partial class admin : Form
    {
        public admin()
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
        private void guna2Shapes4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Environment.Exit(0);
        }

        private void guna2Shapes3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Settings.playMenuSelect();
            if (string.IsNullOrEmpty(searchTB.Text))
            {
                loadData();
                return;
            }

            using (SqlConnection con = new SqlConnection(Settings.server))
            {
                string query = $"SELECT questions, answer FROM Questions WHERE questions LIKE '%{searchTB.Text}%'";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    listTable.DataSource = dt;
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Settings.playMenuSelect();
            questionTB.Text = "";
            loadData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Settings.playMenuSelect();
            string selectedQuestion = "";
            if (listTable.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = listTable.SelectedRows[0];
                selectedQuestion = selectedRow.Cells[0].Value.ToString();

            }
            if (string.IsNullOrWhiteSpace(selectedQuestion))
                return;

            if (MessageBox.Show("Are you sure you want to delete a question?", "WARNING",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string query = $"DELETE FROM Questions WHERE questions = '{selectedQuestion}'";
                using (SqlConnection con = new SqlConnection(Settings.server))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                        loadData();
                    }
                }
            }
        }

        void loadData()
        {
            using (SqlConnection con = new SqlConnection(Settings.server))
            {
                string query = $"SELECT questions, answer FROM Questions";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    listTable.DataSource = dt;
                }
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Settings.playMenuSelect();
            this.Hide();
            start st = new start();
            st.StartPosition = FormStartPosition.CenterParent;
            st.ShowDialog();
            this.Close();
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            Settings.playMenuSelect();
            if (string.IsNullOrWhiteSpace(questionTB.Text) || string.IsNullOrWhiteSpace(answerTB.Text))
            {
                MessageBox.Show("Please fill up the details before adding", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"INSERT INTO Questions (questions, answer) " +
                $"VALUES ('{questionTB.Text}', '{answerTB.Text}');";

            using (SqlConnection con = new SqlConnection(Settings.server))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                    loadData();
                    answerTB.Text = "";
                    questionTB.Text = "";
                    MessageBox.Show("You successfully added a new question", "ADDING SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
