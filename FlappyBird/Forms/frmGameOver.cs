using FlappyBird.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FlappyBird.Forms
{
    public partial class frmGameOver : Form
    {
        // ── Thuộc tính ────────────────────────────────
        private int finalScore;   // điểm vừa đạt, nhận từ engine
        private int highScore;    // điểm cao nhất, đọc từ sql
        private MapConfig currentMap; // map đang dùng, để Retry đúng map

        private string playerName;   // nhận từ frmGame
        private int playerID;     // lấy từ DatabaseHelper

        public bool WantsRetry = false; // frmGame đọc cái này sau khi form đóng


        // ── Constructor ───────────────────────────────
        public frmGameOver(int finalScore, MapConfig currentMap, string playerName)
        {
            InitializeComponent();

            this.finalScore = finalScore;
            this.currentMap = currentMap;
            this.playerName = playerName;

            // Lấy top 1 của map TRƯỚC khi lưu
            int mapTopScoreBefore = DatabaseHelper.GetMapTopScore(currentMap.MapName);

            // Lưu điểm (chỉ lưu nếu cao hơn lần trước của người này)
            playerID = DatabaseHelper.GetOrCreatePlayer(playerName);
            bool saved = DatabaseHelper.SaveScoreIfBetter(playerID, playerName, currentMap.MapName, finalScore);

            // NEW RECORD: chỉ hiện khi vượt top 1 của toàn map
            bool isNewMapRecord = saved && (finalScore > mapTopScoreBefore);
            lblNewRecord.Text = isNewMapRecord ? "🎉 NEW RECORD!" : "";

            // Hiển thị điểm
            lblFinalScore.Text = "SCORE: " + finalScore;

            // Best score cá nhân để hiển thị (lấy lại sau khi đã lưu)
            highScore = DatabaseHelper.GetMapTopScore(currentMap.MapName);
            lblHighScore.Text = "BEST SCORE: " + highScore;


        }
    

        // ── Menu — về màn hình chọn map ───────────────
        private void btnRetry_Click_1(object sender, EventArgs e)
        {
            WantsRetry = true;
            this.Close(); // frmGame sẽ đọc WantsRetry và tạo lại game
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            WantsRetry = false;
            this.Close();

            // Show lại frmMenu để chọn map khác
            // Application.OpenForms tìm form đang mở
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmMenu)
                {
                    f.Show();
                    break;
                }
            }
        }
        private void frmGameOver_Load(object sender, EventArgs e)
        {

        }

        private void lblHighScore_Click(object sender, EventArgs e)
        {

        }

        private void lblNewRecord_Click(object sender, EventArgs e)
        {

        }

        private void lblFinalScore_Click(object sender, EventArgs e)
        {

        }

    }
}