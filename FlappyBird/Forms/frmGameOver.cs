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
           
            // Lấy highScore TRƯỚC khi lưu
            highScore = DatabaseHelper.GetBestScore(playerName, currentMap.MapName);
            
            // Rồi mới lưu
            SaveScore();
            

            // Giờ so sánh mới đúng
            lblNewRecord.Text = (finalScore > highScore) ? "🎉 NEW RECORD!" : "";

            // Cập nhật lại highScore để hiển thị đúng
            highScore = DatabaseHelper.GetBestScore(playerName, currentMap.MapName);
            lblHighScore.Text = "BEST SCORE: " + highScore;
            lblFinalScore.Text = "SCORE: " + finalScore;

            
        }
       
        // ─ Lưu điểm cao nhất xuống file ──────────────
        private void SaveScore()
        {
            playerID = DatabaseHelper.GetOrCreatePlayer(playerName);
            DatabaseHelper.SaveScore(playerID, currentMap.MapName, finalScore);

        }
        // ── Retry — chơi lại cùng map ─────────────────
    

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