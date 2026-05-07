using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FlappyBird.Classes
{
    internal static class DatabaseHelper
    {
        // ── Sửa Server=. nếu tên SQL Server của bạn khác ──
        private static string ConnectionString =
           "Data Source=BTK\\SQLEXPRESS;Initial Catalog=FlappyBirdDB;Integrated Security=True";

        // ── Tìm hoặc tạo người chơi, trả về PlayerID ──────
        public static int GetOrCreatePlayer(string playerName)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                // Tìm xem đã có chưa
                string findSql = "SELECT PlayerID FROM Players WHERE PlayerName = @Name";
                using (var cmd = new SqlCommand(findSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", playerName);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        return (int)result; // đã có → trả về ID luôn
                }

                // Chưa có → INSERT mới
                string insertSql = @"
                    INSERT INTO Players (PlayerName) VALUES (@Name);
                    SELECT SCOPE_IDENTITY();"; // lấy ID vừa tạo

                using (var cmd = new SqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", playerName);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // ── Lưu điểm một ván chơi ─────────────────────────
        public static void SaveScore(int playerID, string mapName, int score)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"
                    INSERT INTO Scores (PlayerID, MapName, Score)
                    VALUES (@PlayerID, @MapName, @Score)";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@PlayerID", playerID);
                    cmd.Parameters.AddWithValue("@MapName", mapName);
                    cmd.Parameters.AddWithValue("@Score", score);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ── Lấy top 10 theo map ───────────────────────────
        public static DataTable GetTopScores(string mapName)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"
                    SELECT TOP 10
                        ROW_NUMBER() OVER (ORDER BY MAX(s.Score) DESC) AS Hang,
                        p.PlayerName  AS [Người chơi],
                        MAX(s.Score)  AS [Điểm cao nhất],
                        MAX(s.PlayedAt) AS [Lần chơi cuối]
                    FROM Scores s
                    JOIN Players p ON s.PlayerID = p.PlayerID
                    WHERE s.MapName = @MapName
                    GROUP BY p.PlayerName
                    ORDER BY [Điểm cao nhất] DESC";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MapName", mapName);
                    var adapter = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        // ── Lấy điểm cao nhất của 1 người theo map ────────
        public static int GetBestScore(string playerName, string mapName)
        {
            if (string.IsNullOrWhiteSpace(playerName))
                playerName = "Anonymous";

            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string sql = @"
            SELECT ISNULL(MAX(s.Score), 0)
            FROM Scores s
            JOIN Players p ON s.PlayerID = p.PlayerID
            WHERE p.PlayerName = @Name 
            AND s.MapName = @MapName";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", playerName);
                    cmd.Parameters.AddWithValue("@MapName", mapName);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}

