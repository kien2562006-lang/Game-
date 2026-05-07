using System;
using System.Drawing;

namespace FlappyBird.Classes
{
    internal class enemy
    {
        public float X;
        public float Y;
        public float SpeedX;
        public float SpeedY;

        public Image Sprite;
        public int Width;
        public int Height;

        public bool IsAlive = true;

        private float time;
        private float originY;
        private int screenW;

        public enemy(float y, Image sprite, int width, int height,
                    float speedX, float speedY, int screenW)
        {
            // 1. Sửa: Bắt đầu từ ngoài cùng bên PHẢI màn hình
            X = screenW;
            Y = y;
            originY = y;

            Sprite = sprite;
            Width = width;
            Height = height;

            SpeedX = speedX;
            SpeedY = speedY;

            this.screenW = screenW;
            time = 0f;
        }

        public void Update(float dt)
        {
            time += dt;

            // 2. Di chuyển sang trái (giảm X)
            X -= SpeedX * dt;

            // Dao động hình sin quanh vị trí Y gốc
            Y = originY + (float)Math.Sin(time * 3f) * SpeedY;

            // 3. Sửa: Chết khi toàn bộ thân quạ đã khuất sau mép TRÁI màn hình (X + Width < 0)
            if (X + Width < 0)
            {
                IsAlive = false;
            }
        }

        public void Draw(Graphics g)
        {
            if (Sprite == null) return;

            // Nếu Sprite của bạn mặc định đã quay mặt sang trái, chỉ cần DrawImage bình thường.
            // Nếu Sprite quay mặt sang phải, dùng đoạn code dưới đây để lật hình:

            var state = g.Save();

            // Di chuyển hệ trục tọa độ đến vị trí con quạ để vẽ
            g.TranslateTransform(X, Y);

            // Nếu cần lật hình (flip) để quạ nhìn sang trái:
            // g.ScaleTransform(-1, 1); 
            // g.DrawImage(Sprite, -Width, 0, Width, Height);

            g.DrawImage(Sprite, 0, 0, Width, Height);

            g.Restore(state);
        }

        public Rectangle GetHitbox()
        {
            // Giữ nguyên hitbox thu nhỏ để tăng trải nghiệm người dùng
            return new Rectangle(
                (int)X + 4,
                (int)Y + 4,
                Width - 8,
                Height - 8
            );
        }
    }
}