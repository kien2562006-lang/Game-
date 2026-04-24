using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird.Classes
{
    internal class MapConfig
    {
        // ── Thông tin map ─────────────────────────────
        public string MapName;
        public Image Background;

        // ── Ảnh cột (tách riêng trên/dưới để linh hoạt) ──
        public Image PipeSkinTop;     // ảnh ống trên
        public Image PipeSkinBottom;  // ảnh ống dưới

        // ── Thông số vật lý ───────────────────────────
        public float Gravity;         // trọng lực tác dụng lên bird
        public float PipeSpeed;       // tốc độ cột di chuyển sang trái
        public int GapSize;         // khoảng hở giữa hai ống
        public int SpawnInterval;   // ms giữa 2 lần tạo cột mới

        // ── Cột di động (level khó) ───────────────────
        public bool MovingPipes;     // bật/tắt cột dao động lên xuống
        public float PipeMoveSpeed;   // tần số dao động (vd: 2.0f)
        public float PipeMoveRange;   // biên độ dao động pixel (vd: 80f)

        // ── Chướng ngại vật & boss ────────────────────
        public List<string> ObstacleTypes;  // danh sách loại obstacle
        public int ScoreThreshold;          // điểm để map này được kích hoạt
        public int BossScore;               // điểm để boss xuất hiện

        // ── Constructor ───────────────────────────────
        public MapConfig(string mapName, Image background,
                         Image pipeSkinTop, Image pipeSkinBottom,
                         float gravity, float pipeSpeed,
                         int gapSize, int spawnInterval,
                         List<string> obstacleTypes,
                         int scoreThreshold, int bossScore,
                         bool movingPipes = false,
                         float pipeMoveSpeed = 2.0f,
                         float pipeMoveRange = 80f)
        {
            MapName = mapName;
            Background = background;
            PipeSkinTop = pipeSkinTop;
            PipeSkinBottom = pipeSkinBottom;
            Gravity = gravity;
            PipeSpeed = pipeSpeed;
            GapSize = gapSize;
            SpawnInterval = spawnInterval;
            ObstacleTypes = obstacleTypes;
            ScoreThreshold = scoreThreshold;
            BossScore = bossScore;
            MovingPipes = movingPipes;
            PipeMoveSpeed = pipeMoveSpeed;
            PipeMoveRange = pipeMoveRange;
        }
    }
}
