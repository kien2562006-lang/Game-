using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.Classes
{
  public class Pipe
  {
        // ── Vị trí & kích thước ───────────────────────
        public float X;
        public float GapY; // tọa độ tâm của khoảng cách 2 cột 
        public int GapSize;
        public int Width = 60;

        // ── Chuyển động ───────────────────────────────
        public float SpeedX;
        public bool IsMoving;
        public float MoveSpeedY;
        public float MoveRange;

        // ── Hình ảnh ──────────────────────────────────
        public Image SkinTop;
        public Image SkinBottom;

        // ── Trạng thái ────────────────────────────────
        public bool IsAlive = true; // thêm vào — GameEngine cần cái này
        public bool Scored = false;

        // ── Biến nội bộ ───────────────────────────────
        private float originGapY;
        private float time;

        // ── Constructor ───────────────────────────────
        public Pipe(float x, float gapY, int gapSize, float speed,
                    Image top, Image bottom,
                    bool isMoving = false,
                    float moveSpeed = 2f,
                    float moveRange = 80f)
        {
            X = x;
            GapY = gapY;
            GapSize = gapSize;
            SpeedX = speed;

            SkinTop = top;
            SkinBottom = bottom;

            IsMoving = isMoving;
            MoveSpeedY = moveSpeed;
            MoveRange = moveRange;

            originGapY = gapY;
            time = 0f;
        }

        // ── Update ────────────────────────────────────
        public void Update(float dt)
        {
            X -= SpeedX * dt;

            if (IsMoving)
            {
                time += dt;
                GapY = originGapY + (float)Math.Sin(time * MoveSpeedY) * MoveRange;
                // maxpipespeedX = ?? speedX
            }


            // tự set IsAlive — GameEngine sẽ xóa pipe này
            if (IsOffScreen())
                IsAlive = false;
        }

        // ── Kiểm tra ra màn hình ──────────────────────
        public bool IsOffScreen()
        {
            return X + Width <= 0;
        }

        // ── Hitbox ────────────────────────────────────
        public Rectangle GetTopBounds()
        {
            int height = (int)(GapY - GapSize / 2);
            height = Math.Max(0, height);
            return new Rectangle((int)X, 0, Width, height);
        }

        public Rectangle GetBottomBounds(int screenHeight)
        {
            int top = (int)(GapY + GapSize / 2);
            return new Rectangle((int)X, top, Width, screenHeight - top);
        }

        // ── Draw ──────────────────────────────────────
        public void Draw(Graphics g, int screenHeight)
        {
            if (SkinTop == null || SkinBottom == null) return;

            var topRect = GetTopBounds();
            var bottomRect = GetBottomBounds(screenHeight);

            // chỉ vẽ nếu hình chữ nhật có kích thước hợp lệ
            if (topRect.Height > 0)
                g.DrawImage(SkinTop, topRect);

            if (bottomRect.Height > 0)
                g.DrawImage(SkinBottom, bottomRect);
        }
    }
}