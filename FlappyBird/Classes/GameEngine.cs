using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.Classes
{
    internal class GameEngine
    {
        // ── Đối tượng game ────────────────────────────
        public Bird bird;                    // nhân vật chính
        public List<Pipe> pipes;             // danh sách cột đang hiển thị
        public List<object> obstacles;       // danh sách Crow / Hazard đang hoạt động
        public object boss;                  // null nếu chưa xuất hiện

        // ── Cấu hình map ──────────────────────────────
        public MapConfig currentMap;         // map được chọn từ đầu, cố định suốt ván

        // ── Thông số màn hình ─────────────────────────
        public int screenW;
        public int screenH;

        // ── Điểm số ───────────────────────────────────
        public int score;

        // ── Bộ đếm spawn ─────────────────────────────
        private float spawnTimer;            // đếm ms để biết khi nào spawn cột mới
        private float obstacleTimer;         // đếm ms để biết khi nào spawn obstacle mới

        // ── Trạng thái game ───────────────────────────
        private bool isRunning;             // false khi game kết thúc

        // ── Event thông báo thua ──────────────────────
        // frmGame đăng ký event này để nhận thông báo khi bird chết
        public event Action<int> OnGameOver;

        // ── Random dùng chung ─────────────────────────
        private Random rng = new Random();

        // ══════════════════════════════════════════════
        // Constructor
        // Nhận MapConfig từ frmMenu, khởi tạo toàn bộ đối tượng game
        // ══════════════════════════════════════════════
        public GameEngine(MapConfig map, int screenW, int screenH)
        {
            currentMap = map;
            this.screenW = screenW;
            this.screenH = screenH;

            pipes = new List<Pipe>();
            obstacles = new List<object>();
            boss = null;
            score = 0;
            spawnTimer = 0f;
            obstacleTimer = 0f;
            isRunning = true;

            // Tạo bird ở giữa màn hình theo chiều ngang,
            // 1/3 từ trên xuống theo chiều dọc
            bird = new Bird(
                x: screenW / 3f,
                y: screenH / 3f,
                sprite: map.Background,   // tạm dùng background, thay bằng ảnh bird thực tế
                width: 40,
                height: 30,
                gravity: map.Gravity,
                screenH: screenH
            );
        }

        // ══════════════════════════════════════════════
        // Update — gọi mỗi 16ms từ Timer_Tick của frmGame
        // Cập nhật toàn bộ trạng thái game theo thời gian thực
        // ══════════════════════════════════════════════
        public void Update(float dt)
        {
            if (!isRunning) return; // game đã kết thúc, không làm gì thêm

            // 1. Cập nhật bird
            bird.Update(dt);

            // 2. Đếm thời gian để spawn cột mới
            spawnTimer += dt * 1000f; // chuyển dt (giây) sang ms để so sánh với SpawnInterval
            if (spawnTimer >= currentMap.SpawnInterval)
            {
                SpawnPipe();
                spawnTimer = 0f; // reset bộ đếm
            }

            // 3. Cập nhật tất cả cột, kiểm tra tính điểm
            foreach (var pipe in pipes)
            {
                pipe.Update(dt);

                // Tính điểm khi bird vượt qua giữa cột
                // Điều kiện: cột vừa đi qua vị trí X của bird
                if (!pipe.IsAlive && pipe.X + pipe.Width < bird.X)
                    score++;
            }

            // 4. Xóa các cột đã ra khỏi màn hình
            pipes.RemoveAll(p => !p.IsAlive);

            // 5. Đếm thời gian để spawn obstacle mới
            obstacleTimer += dt * 1000f;
            if (obstacleTimer >= 3000f) // spawn obstacle mỗi 3 giây
            {
                SpawnObstacle();
                obstacleTimer = 0f;
            }

            // 6. Xóa các obstacle đã hết hiệu lực
            obstacles.RemoveAll(o => o == null);

            // 7. Kiểm tra va chạm
            CheckCollision();

            // 8. Kiểm tra spawn boss
            CheckBossSpawn();
        }

        // ══════════════════════════════════════════════
        // Draw — gọi từ OnPaint của frmGame
        // Vẽ theo thứ tự từ sau ra trước để bird luôn hiển thị trên cùng
        // ══════════════════════════════════════════════
        public void Draw(Graphics g)
        {
            // 1. Vẽ background (lớp dưới cùng)
            if (currentMap.Background != null)
                g.DrawImage(currentMap.Background, 0, 0, screenW, screenH);

            // 2. Vẽ tất cả cột
            foreach (var pipe in pipes)
                pipe.Draw(g, screenH);

            // 3. Vẽ HUD — điểm số góc trên bên trái
            g.DrawString(
                score.ToString(),
                new Font("Arial", 24, FontStyle.Bold),
                Brushes.White,
                new PointF(screenW / 2f - 15, 20f)
            );

            // 4. Vẽ bird (lớp trên cùng)
            bird.Draw(g);
        }

        // ══════════════════════════════════════════════
        // SpawnPipe — tạo cột mới từ bên phải màn hình
        // GapY ngẫu nhiên trong vùng an toàn để người chơi luôn có thể vượt qua
        // ══════════════════════════════════════════════
        private void SpawnPipe()
        {
            // GapY nằm trong khoảng [20% → 80%] chiều cao màn hình
            // tránh khoảng hở quá sát đỉnh hoặc đáy
            int minGapY = (int)(screenH * 0.2f);
            int maxGapY = (int)(screenH * 0.8f);
            float gapY = rng.Next(minGapY, maxGapY);

            var pipe = new Pipe(
                x: screenW,                         // xuất hiện từ bên phải màn hình
                gapY: gapY,
                gapSize: currentMap.GapSize,
                speed: currentMap.PipeSpeed,
                top: currentMap.PipeSkinTop,
                bottom: currentMap.PipeSkinBottom,
                isMoving: currentMap.MovingPipes,
                moveSpeed: currentMap.PipeMoveSpeed,
                moveRange: currentMap.PipeMoveRange
            );

            pipes.Add(pipe);
        }

        // ══════════════════════════════════════════════
        // SpawnObstacle — tạo obstacle dựa vào danh sách ObstacleTypes của map
        // Hiện tại để trống, sẽ bổ sung khi có class Crow và Hazard
        // ══════════════════════════════════════════════
        private void SpawnObstacle()
        {
            if (currentMap.ObstacleTypes == null || currentMap.ObstacleTypes.Count == 0)
                return;

            // Random chọn loại obstacle từ danh sách của map
            string type = currentMap.ObstacleTypes[rng.Next(currentMap.ObstacleTypes.Count)];

            // TODO: tạo Crow hoặc Hazard tương ứng với type
            // sau khi có class Crow và Hazard sẽ bổ sung vào đây
            // if (type == "crow") obstacles.Add(new Crow(...));
            // else obstacles.Add(new Hazard(type, ...));
        }

        // ══════════════════════════════════════════════
        // CheckCollision — kiểm tra va chạm giữa bird và tất cả chướng ngại vật
        // Nếu có va chạm → gọi GameOver()
        // ══════════════════════════════════════════════
        private void CheckCollision()
        {
            // Bird đã chết do chạm đáy/đỉnh màn hình (xử lý trong Bird.Update)
            if (!bird.IsAlive)
            {
                GameOver();
                return;
            }

            Rectangle birdBox = bird.GetHitbox();

            // Kiểm tra va chạm với từng cột
            foreach (var pipe in pipes)
            {
                if (birdBox.IntersectsWith(pipe.GetTopBounds()) ||
                    birdBox.IntersectsWith(pipe.GetBottomBounds(screenH)))
                {
                    GameOver();
                    return; // dừng ngay, không cần kiểm tra tiếp
                }
            }

            // TODO: kiểm tra va chạm với obstacles và boss
            // sau khi có class Crow, Hazard, Boss sẽ bổ sung vào đây
        }

        // ══════════════════════════════════════════════
        // CheckBossSpawn — kiểm tra có cần tạo boss không
        // Boss xuất hiện khi score đạt ngưỡng BossScore của map
        // ══════════════════════════════════════════════
        private void CheckBossSpawn()
        {
            if (score >= currentMap.BossScore && boss == null)
            {
                // TODO: tạo Boss khi có class Boss
                // boss = new Boss(...);
            }
        }

        // ══════════════════════════════════════════════
        // GameOver — kết thúc game, thông báo về frmGame qua event
        // ══════════════════════════════════════════════
        private void GameOver()
        {
            if (!isRunning) return; // tránh gọi nhiều lần

            isRunning = false;

            // Raise event — frmGame sẽ nhận và hiển thị frmGameOver
            OnGameOver?.Invoke(score);
        }
    }
}