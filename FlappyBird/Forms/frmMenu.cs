using FlappyBird.Classes;
using FlappyBird.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class frmMenu : Form
    {
        // ── Thuộc tính ────────────────────────────────
        private MapConfig selectedMap;
        private int highScore;

        // ── Constructor ───────────────────────────────
        public frmMenu()
        {
            InitializeComponent();

            // Mặc định chọn Forest
            selectedMap = MapConfig.Forest;
            HighlightButton(btnForest);

            LoadHighScore();
        }

        // ══════════════════════════════════════════════
        // Load điểm cao nhất từ file
        // ══════════════════════════════════════════════
        private void LoadHighScore()
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "scores.txt");

                if (File.Exists(path))
                {
                    string content = File.ReadAllText(path).Trim();

                    // parse an toàn
                    highScore = int.TryParse(content, out int score) ? score : 0;
                }
                else
                {
                    highScore = 0;
                }
            }
            catch
            {
                highScore = 0;
            }

            lblHighScore.Text = "Điểm cao nhất: " + highScore;
        }

        // ══════════════════════════════════════════════
        // Chọn map
        // ══════════════════════════════════════════════
        private void btnForest_Click(object sender, EventArgs e)
        {
            selectedMap = MapConfig.Forest;
            HighlightButton(btnForest);
        }

        private void btnVolcano_Click(object sender, EventArgs e)
        {
            selectedMap = MapConfig.Volcano;
            HighlightButton(btnVolcano);
        }

        private void btnStorm_Click(object sender, EventArgs e)
        {
            selectedMap = MapConfig.Storm;
            HighlightButton(btnStorm);
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            selectedMap = MapConfig.Space;
            HighlightButton(btnSpace);
        }

        // ── Highlight nút ─────────────────────────────
        private void HighlightButton(Button selected)
        {
            var mapButtons = new List<Button>
            {
                btnForest, btnVolcano, btnStorm, btnSpace
            };

            foreach (var btn in mapButtons)
            {
                btn.FlatStyle = FlatStyle.Flat;

                if (btn == selected)
                {
                    btn.FlatAppearance.BorderSize = 4;
                    btn.FlatAppearance.BorderColor = Color.White;
                }
                else
                {
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.Gray;
                }
            }
        }

        // ══════════════════════════════════════════════
        // Start game
        // ══════════════════════════════════════════════
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Tạo engine
            GameEngine engine = new GameEngine(
                selectedMap,
                this.ClientSize.Width,
                this.ClientSize.Height
            );

            // Mở game
            frmGame game = new frmGame(engine);

            game.FormClosed += (s, args) =>
            {
                this.Visible = true;
                LoadHighScore();
            };

            this.Visible = false;
            game.Show();
        }

        // ══════════════════════════════════════════════
        // Leaderboard (chưa làm)
        // ══════════════════════════════════════════════
        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa làm bảng xếp hạng 😄");
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}