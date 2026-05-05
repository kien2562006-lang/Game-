using FlappyBird.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird.Forms
{
    public partial class frmLeaderboard : Form
    {
        private string selectedMap = "Forest"; // mặc định

        public frmLeaderboard()
        {
            InitializeComponent();

            // Thêm 4 map vào ComboBox
            cboMap.Items.AddRange(new[] { "Forest", "Volcano", "Storm", "Space" });
            cboMap.SelectedIndex = 0;
            cboMap.SelectedIndexChanged += cboMap_SelectedIndexChanged;

            // Cài đặt DataGridView
           
            dgvScores.RowHeadersVisible = false;
            dgvScores.AllowUserToAddRows = false;
            dgvScores.ReadOnly = true;
            dgvScores.BackgroundColor = Color.FromArgb(20, 20, 35);
            dgvScores.GridColor = Color.FromArgb(40, 60, 80);
            dgvScores.DefaultCellStyle.BackColor = Color.FromArgb(15, 15, 25);
            dgvScores.DefaultCellStyle.ForeColor = Color.White;
            dgvScores.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvScores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 80, 120);
            dgvScores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvScores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvScores.EnableHeadersVisualStyles = false;

            LoadScores("Forest");
        }

        private void LoadScores(string mapName)
        {
            try
            {
                dgvScores.DataSource = DatabaseHelper.GetTopScores(mapName);
                // Chỉnh độ rộng từng cột
                dgvScores.Columns["Hang"].Width = 60;
                dgvScores.Columns["Người chơi"].Width = 180;
                dgvScores.Columns["Điểm cao nhất"].Width = 120;
                dgvScores.Columns["Lần chơi cuối"].Width = 220;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối SQL:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMap = cboMap.SelectedItem.ToString();
            LoadScores(selectedMap);
        }

        private void frmLeaderBoard_Load(object sender, EventArgs e)
        {

        }

        private void dgvScores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
