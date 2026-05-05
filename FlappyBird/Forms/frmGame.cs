using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using FlappyBird.Classes;

namespace FlappyBird.Forms
{
    public partial class frmGame : Form
    {
        // ── Thuộc tính ────────────────────────────────
        private GameEngine engine;  // toàn bộ logic game nằm đây
        private Timer timer;        // 16ms tick (~60fps)
        private Stopwatch stopwatch; // đo delta time chính xác
        private string playerName;
        public bool IsRetrying = false;
        // ── Constructor ───────────────────────────────
        // Nhận GameEngine đã được tạo sẵn từ frmMenu
        public frmGame(GameEngine engine, string playerName)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.engine = engine;
            this.playerName = playerName;

            // Bắt buộc — tránh nhấp nháy khi vẽ 60fps
            this.DoubleBuffered = true;

            // Đăng ký lắng nghe event GameOver từ engine
            // Khi bird chết, engine sẽ gọi event này
            this.engine.OnGameOver += Engine_OnGameOver;

            // Khởi tạo timer
            timer = new Timer();
            timer.Interval = 16; // ~60fps
            timer.Tick += Timer_Tick;

            // Khởi tạo stopwatch để đo delta time thực tế
            stopwatch = new Stopwatch();
        }

        // ── Load form ─────────────────────────────────
        private void frmGame_Load(object sender, EventArgs e)
        {
            // Đặt kích thước form khớp với screenW/H của engine
            this.ClientSize = new Size(engine.screenW, engine.screenH);

            stopwatch.Start();
            timer.Start();
        }

        // ── Timer_Tick — trái tim của game ────────────
        // Gọi mỗi 16ms: tính dt → update engine → vẽ lại
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Tính delta time (số giây từ lần tick trước đến giờ)
            float dt = (float)stopwatch.Elapsed.TotalSeconds;
            stopwatch.Restart(); // reset để lần sau tính tiếp

            // Cập nhật toàn bộ logic game
            engine.Update(dt);

            // Kích hoạt OnPaint để vẽ lại màn hình
            this.Invalidate();
        }

        // ── OnPaint — vẽ toàn bộ màn hình ─────────────
        // Form không tự vẽ gì — chỉ giao cho engine
        protected override void OnPaint(PaintEventArgs e)
        {
            engine.Draw(e.Graphics);
        }

        // ── OnKeyDown — nhận input bàn phím ───────────
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (engine.IsWaitingToStart)
                {
                    engine.StartGame(); // lần đầu nhấn → bắt đầu game
                    engine.bird.Flap();
                }
                else
                    engine.bird.Flap(); // các lần sau → flap
            }

            if (e.KeyCode == Keys.P)
                engine.TogglePause();

            // Nhấn Escape → thoát về menu
            if (e.KeyCode == Keys.Escape)
            {
                timer.Stop();
                this.Close();
            }
        }

        // ── Engine_OnGameOver — nhận event khi thua ───
        // Engine gọi event này khi bird chết
        private void Engine_OnGameOver(int finalScore)
        {
            timer.Stop();
            stopwatch.Stop();

            this.Invoke((Action)(() =>
            {
                string name = string.IsNullOrWhiteSpace(playerName) ? "Anonymous" : playerName;
                // Thêm engine.currentMap vào tham số
                var gameOver = new frmGameOver(finalScore, engine.currentMap, playerName);
                gameOver.ShowDialog();

                if (gameOver.WantsRetry)
                {
                    IsRetrying = true;
                    var newEngine = new GameEngine(
                        engine.currentMap,
                        engine.screenW,
                        engine.screenH
                    );
                    var newGame = new frmGame(newEngine,playerName);
                    newGame.Show();
                }

                this.Close();
            }));
        }

        // ── Dọn dẹp khi form đóng ─────────────────────
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            stopwatch.Stop();
            base.OnFormClosed(e);
        }

        

        private void btnPause_Click_1(object sender, EventArgs e)
        {
            engine.TogglePause();
            btnPause.Text = engine.IsPaused ? "▶" : "⏸";
        }
    }
}