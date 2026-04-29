using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace FlappyBird.Classes
{
    public class Bird
    {
        // ── Vị trí & chuyển động ──────────────────────
        public float X, Y;
        public float velocityY;
        public float gravity;       // nhận từ MapConfig khi tạo Bird

        // ── Thông số bay ──────────────────────────────
        public float flapForce = 350f;
        public float maxFallSpeed = 500f;

        // ── Hiển thị ──────────────────────────────────
        public Image sprite;
        public int Width, Height;

        // ── Trạng thái ────────────────────────────────
        public bool IsAlive = true;

        private int _screenH; // chiều cao màn hình, không cứng số

        // ── Constructor ───────────────────────────────
        public Bird(float x, float y, Image sprite, int width, int height,
                    float gravity, int screenH)
        {
            X = x;
            Y = y;
            this.sprite = sprite;
            Width = width;
            Height = height;
            this.gravity = gravity;
            _screenH = screenH;

            ImageAnimator.Animate(this.sprite, null);
        }

        // ── Update ────────────────────────────────────
        public void Update(float dt)  // bỏ tham số gravity — Bird tự có rồi
        {
            velocityY += gravity * dt;
            velocityY = Math.Min(velocityY, maxFallSpeed); // giới hạn tốc độ rơi

            Y += velocityY * dt;

            // chạm đỉnh hoặc đáy màn hình → chết
            if (Y < 0 || Y + Height > _screenH)
                IsAlive = false;
        }

        // ── Flap ──────────────────────────────────────
        public void Flap()
        {
            velocityY = -flapForce; // đặt lại tốc độ lên, không cộng thêm
        }

        // ── Draw ──────────────────────────────────────
        public void Draw(Graphics g)
        {
            if (sprite == null) return; // tránh crash nếu chưa load ảnh
                                        // Tính góc xoay dựa theo tốc độ rơi
            ImageAnimator.UpdateFrames(sprite);

            float angle = velocityY * 0.1f;
            if (angle < -30f) angle = -30f; // giới hạn góc ngẩng lên tối đa 30 
            if (angle > 90f) angle = 90f; // giới hạn góc ngẩng lên tối đa 90

            // Tâm xoay là giữa sprite
            float cx = X + Width / 2f;
            float cy = Y + Height / 2f;

            var state = g.Save();
            g.TranslateTransform(cx, cy);
            g.RotateTransform(angle);
            g.DrawImage(sprite, -Width / 2f, -Height / 2f, Width, Height);
            g.Restore(state);
        }

        // ── Hitbox ────────────────────────────────────
        public Rectangle GetHitbox()
        {
            int padding = 5;
            return new Rectangle(
                (int)X + padding,
                (int)Y + padding,
                Width - padding * 2,
                Height - padding * 2
            );
        }
    }
}
