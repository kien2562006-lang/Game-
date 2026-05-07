using FlappyBird.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.Classes
{
    public class GameEngine
    {
        // ── Đối tượng game ────────────────────────────
        public Bird bird;                    // nhân vật chính
        public List<Pipe> pipes;             // danh sách cột đang hiển thị
        public List<object> obstacles;       // danh sách enemy / Hazard đang hoạt động
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
        public bool IsWaitingToStart = true;
        public bool IsPaused = false;
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
                sprite: Resources.bird_gif, 
                width: 40,
                height: 37,
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
            if (!isRunning) return;

            if (IsWaitingToStart) return;

            if (IsPaused) return;
            // 1. Cập nhật bird
            bird.Update(dt);

            // 2. Đếm thời gian để spawn cột mới
            spawnTimer += dt * 1000f;
            if (spawnTimer >= currentMap.SpawnInterval)
            {
                SpawnPipe();
                spawnTimer = 0f;
            }

            // 3. Cập nhật tất cả cột, kiểm tra tính điểm
            foreach (var pipe in pipes)
            {
                pipe.Update(dt);

                if (pipe.IsAlive && pipe.X + pipe.Width < bird.X && !pipe.Scored)
                {
                    score++;
                    pipe.Scored = true;
                }
            }

            // ── Bật tính năng theo mốc điểm ─────────────── ← THÊM VÀO ĐÂY
            if (score >= 15 && !currentMap.MovingPipes)
            {
                currentMap.MovingPipes = true;

                // Cập nhật luôn các cột đang có trên màn hình
                foreach (var pipe in pipes)
                    pipe.IsMoving = true;
            }
            // dung cho retry
            if(score == 0 &&currentMap.MovingPipes==true)
            {
                currentMap.MovingPipes = false;

                // Cập nhật luôn các cột đang có trên màn hình
                foreach (var pipe in pipes)
                    pipe.IsMoving = false;
            }
            // ─────────────────────────────────────────────────────────────

            // 4. Xóa các cột đã ra khỏi màn hình
            pipes.RemoveAll(p => !p.IsAlive);


            // 5. Đếm thời gian để spawn obstacle mới
            if (score >= 2)
            {
                obstacleTimer += dt * 1000f;
                if (obstacleTimer >= 3000f) // Cứ 3 giây tạo 1 con quạ
                {
                    SpawnObstacle();
                    obstacleTimer = 0f;
                }
            }



            // 6. Xóa các obstacle đã hết hiệu lực
            foreach (var obj in obstacles)
            {
                if (obj is enemy e)
                {
                    e.Update(dt);
                }
            }

            // 7. Kiểm tra va chạm
            CheckCollision();
                //Xóa obstacles (quạ) đã chết
            obstacles.RemoveAll(o => o is enemy c && !c.IsAlive); 

            // 8. Kiểm tra spawn boss
            CheckBossSpawn();
            
        }
        public void StartGame()
        {
            IsWaitingToStart = false; // bắt đầu chạy
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

            // 5. Vẽ obstacles quạ
            foreach (var obj in obstacles)
            {
                if (obj is enemy enemy)
                    enemy.Draw(g);
            }

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
            //tăng tốc độ cột đến MaxPipesSpeedX
            float currentSpeed = Math.Min(
            currentMap.PipeSpeedX + score * 2f,
            currentMap.MaxPipeSpeedX
            );

            var pipe = new Pipe(
                x: screenW,                         // xuất hiện từ bên phải màn hình
                gapY: gapY,
                gapSize: currentMap.GapSize,
                speed: currentSpeed,
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
        // Hiện tại để trống, sẽ bổ sung khi có class enemy và Hazard
        // ══════════════════════════════════════════════
        private void SpawnObstacle()
        {
            if (currentMap.ObstacleTypes == null || currentMap.ObstacleTypes.Count == 0)
                return;

            // Random chọn loại obstacle từ danh sách của map
            string type = currentMap.ObstacleTypes[rng.Next(currentMap.ObstacleTypes.Count)];

            // TODO: tạo enemy hoặc Hazard tương ứng với type
            // sau khi có class enemy và Hazard sẽ bổ sung vào đây
            // if (type == "enemy") obstacles.Add(new enemy(...));
            // else obstacles.Add(new Hazard(type, ...));
            if (type == "enemy")
            {
                obstacles.Add(new enemy(
                    y: rng.Next((int)(screenH * 0.1f), (int)(screenH * 0.8f)),
                    sprite: currentMap.EnemySprite,   // ← lấy ảnh từ map hiện tại
                    width: 60,
                    height: 45,
                    speedX: currentMap.enemySpeedX,
                    speedY: 30f,
                    screenW: screenW
                ));
            }
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
            // sau khi có class enemy, Hazard, Boss sẽ bổ sung vào đây
            // Kiểm tra va chạm với obstacles
            foreach (var obj in obstacles)
            {
                if (obj is enemy enemy && birdBox.IntersectsWith(enemy.GetHitbox()))
                {
                    GameOver();
                    return;
                }
            }

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
        public void TogglePause()
        {
            IsPaused = !IsPaused;
        }
    }
}