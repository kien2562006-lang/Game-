using System;
using System.IO;
using System.Windows.Forms;
using FlappyBird.Classes;

namespace FlappyBird.Forms
{
    public partial class frmGameOver : Form
    {
        // ── Thuộc tính ────────────────────────────────
        private int finalScore;   // điểm vừa đạt, nhận từ engine
        private int highScore;    // điểm cao nhất, đọc từ file
        private MapConfig currentMap; // map đang dùng, để Retry đúng map

        public bool WantsRetry = false; // frmGame đọc cái này sau khi form đóng

        // ── Đường dẫn file lưu điểm ──────────────────
        private static string ScoreFilePath =
            Path.Combine(Application.StartupPath, "scores.txt");

        // ── Constructor ───────────────────────────────
        public frmGameOver(int finalScore, MapConfig currentMap)
        {
            InitializeComponent();

            this.finalScore = finalScore;
            this.currentMap = currentMap;
            // Đọc điểm cao nhất từ file
            highScore = LoadHighScore();

            // Lưu nếu điểm mới cao hơn
            SaveHighScore();

            // Hiển thị điểm lên label
            lblFinalScore.Text = "Điểm của bạn: " + finalScore.ToString();
            lblHighScore.Text = "Điểm cao nhất: " + highScore.ToString();

            // Nếu vừa phá kỷ lục thì hiện thông báo
            if (finalScore >= highScore)
                lblNewRecord.Text = "🎉 Kỷ lục mới!";
            else
                lblNewRecord.Text = "";

        }

        // ── Đọc điểm cao nhất từ file ─────────────────
        private int LoadHighScore()
        {
            // Nếu file chưa tồn tại thì trả về 0
            if (!File.Exists(ScoreFilePath))
                return 0;

            // Đọc file, thử parse sang int
            string content = File.ReadAllText(ScoreFilePath).Trim();
            if (int.TryParse(content, out int saved))
                return saved;

            return 0; // file bị lỗi định dạng → coi như 0
        }

        // ── Lưu điểm cao nhất xuống file ──────────────
        private void SaveHighScore()
        {
            // Chỉ ghi đè nếu điểm mới cao hơn
            if (finalScore > highScore)
            {
                highScore = finalScore; // cập nhật biến luôn để hiển thị đúng
                File.WriteAllText(ScoreFilePath, highScore.ToString());
            }
        }

        // ── Retry — chơi lại cùng map ─────────────────
        private void btnRetry_Click(object sender, EventArgs e)
        {
            WantsRetry = true;
            this.Close(); // frmGame sẽ đọc WantsRetry và tạo lại game
        }

        // ── Menu — về màn hình chọn map ───────────────
        private void btnMenu_Click(object sender, EventArgs e)
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
    }
}