using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Unilab2019.Helpers.Types;


namespace Unilab2019.Objects.Player
{
    class Player : GameObject
    {
        public Player(int x, int y) : base(x, y)
        {
            Bitmaps[(int)Direction.None] = GetBitmap("Player_None.jpg");
            Bitmaps[(int)Direction.Up] = GetBitmap("Player_Up.jpg");
            Bitmaps[(int)Direction.Down] = GetBitmap("Player_Down.jpg");
            Bitmaps[(int)Direction.Right] = GetBitmap("Player_Right.jpg");
            Bitmaps[(int)Direction.Left] = GetBitmap("Player_Left.jpg");
        }
        public int HP { get; set; }

        public int MaxHP { get; set; }

        public int Pedometer { get; set; } 
        // 歩数計

        public int DesiredPedometer { get; set; } 
        // 歩数の目標値

        public bool Intersect(GameObject obj) => X == obj.X && Y == obj.Y;
        // objとPlayerが同一座標にいるかを判定
        // Goalと各イベントアイテムに使用

        public override void Draw(Graphics graphics, float width, float height)
        {
            if (!IsAlive) return;
            graphics.DrawImage(Bitmaps[(int)Direction], X * width, Y * height, width, height);
        }
    }
}
