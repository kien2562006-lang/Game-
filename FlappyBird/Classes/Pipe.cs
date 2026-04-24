using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.Classes
{
  internal class Pipe
  {
        public float X;
        public float GapY;
        public int GapSize;
        public int Width = 60;

        public float Speed;

        public bool IsMoving;
        public float MoveSpeed;
        public float MoveRange;

        public Image SkinTop;
        public Image SkinBottom;

        private float originGapY;
        private float time;

        public Pipe(float x, float gapY, int gapSize, float speed,
                    Image top, Image bottom,
                    bool isMoving = false,
                    float moveSpeed = 2f,
                    float moveRange = 80f)
        {
            X = x;
            GapY = gapY;
            GapSize = gapSize;
            Speed = speed;

            SkinTop = top;
            SkinBottom = bottom;

            IsMoving = isMoving;
            MoveSpeed = moveSpeed;
            MoveRange = moveRange;

            originGapY = gapY;
            time = 0f;
        }

        public void Update(float dt)
        {
            X -= Speed * dt;

            if (IsMoving)
            {
                time += dt;
                GapY = originGapY + (float)Math.Sin(time * MoveSpeed) * MoveRange;
            }
        }

        public bool IsOffScreen()
        {
            return X + Width <= 0;
        }

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

        public void Draw(Graphics g, int screenHeight)
        {
            var topRect = GetTopBounds();
            var bottomRect = GetBottomBounds(screenHeight);

            g.DrawImage(SkinTop, topRect);
            g.DrawImage(SkinBottom, bottomRect);
        }


    }
}