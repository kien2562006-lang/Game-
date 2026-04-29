using FlappyBird.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.Classes
{
    public  class MapConfig
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
        public int BossScore;               // điểm để boss xuất hiện

        // ── Constructor ───────────────────────────────
        public MapConfig(string mapName, Image background,
                         Image pipeSkinTop, Image pipeSkinBottom,
                         float gravity, float pipeSpeed,
                         int gapSize, int spawnInterval,
                         List<string> obstacleTypes,
                         int bossScore,
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
            BossScore = bossScore;
            MovingPipes = movingPipes;
            PipeMoveSpeed = pipeMoveSpeed;
            PipeMoveRange = pipeMoveRange;
        }
        // ── 4 map tĩnh — dùng ở bất kỳ đâu trong project ──

        public static MapConfig Forest => new MapConfig(
            mapName: "Forest",
            background: Resources.Forest,
            pipeSkinTop: Resources.pipe_forest,
            pipeSkinBottom: Resources.pipe_forest,
            gravity: 800f,
            pipeSpeed: 200f,
            gapSize: 160,
            spawnInterval: 1800,
            obstacleTypes: new List<string> { "crow", "tree" },
            bossScore: 15
        );

        public static MapConfig Volcano => new MapConfig(
            mapName: "Volcano",
            background: Resources.Volcano,
            pipeSkinTop: Resources.pipe_volcano,
            pipeSkinBottom: Resources.pipe_volcano,
            gravity: 850f,
            pipeSpeed: 220f,
            gapSize: 150,
            spawnInterval: 1600,
            obstacleTypes: new List<string> { "fire", "meteor" },
            bossScore: 35
        );

        public static MapConfig Storm => new MapConfig(
            mapName: "Storm",
            background: Resources.Storm,
            pipeSkinTop: Resources.pipe_storm,
            pipeSkinBottom: Resources.pipe_storm,
            gravity: 900f,
            pipeSpeed: 250f,
            gapSize: 140,
            spawnInterval: 1400,
            obstacleTypes: new List<string> { "lightning", "crow" },
            bossScore: 55,
            movingPipes: true   // từ map này cột bắt đầu di động
        );

        public static MapConfig Space => new MapConfig(
            mapName: "Galaxy",
            background: Resources.Space,
            pipeSkinTop: Resources.pipe_space,
            pipeSkinBottom: Resources.pipe_space,
            gravity: 950f,
            pipeSpeed: 280f,
            gapSize: 130,
            spawnInterval: 1200,
            obstacleTypes: new List<string> { "meteor", "laser" },
            bossScore: 80,
            movingPipes: true
        );
    }
}
