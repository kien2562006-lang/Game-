using System.Drawing;

namespace FlappyBird.Classes
{

}

public enum MapType
{
    Forest,
    Volcano,
    Space,
    Storm
}

public class MapConfig
{
    //MAP 
    public MapType Type { get; set; }

 
    public int PipeSpeed { get; set; }      // Tốc độ cột di chuyển
    public int GapSize { get; set; }        // Khoảng hở giữa 2 cột
    public int Gravity { get; set; }        // Trọng lực map (Space thấp hơn)
    public bool WindActive { get; set; }    // Có gió thổi ngược không

    // ── SPAWN ──────────────────────────────────
    public int EnemySpawnScore { get; set; } // Điểm bắt đầu xuất hiện quạ

    // ── HÌNH ẢNH ──────────────────────────────
    public Image Background { get; set; }   // Ảnh nền map
    public Image PipeImage { get; set; }    // Ảnh cột theo map
}