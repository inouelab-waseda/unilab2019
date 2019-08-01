using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Unilab2019.Helpers.Types;


namespace Unilab2019.Objects.Enemies
{
    class Enemy : GameObject
    {
        //未完成
        public Enemy(int x, int y) : base(x, y)
        {
            Bitmaps[(int)Direction.None] = GetBitmap("Enemy.jpg");
            Bitmaps[(int)Direction.Up] = GetBitmap("Enemy_up.jpg");
            Bitmaps[(int)Direction.Down] = GetBitmap("Enemy_Down.jpg");
            Bitmaps[(int)Direction.Right] = GetBitmap("Enemy_Right.jpg");
            Bitmaps[(int)Direction.Left] = GetBitmap("Enemy_Left.jpg");
        }
        public override void Draw(Graphics graphics, float width, float height)
        {
            if (!IsAlive) return;
            graphics.DrawImage(Bitmaps[(int)Direction], X * width, Y * height, width, height);
        }
    }

}