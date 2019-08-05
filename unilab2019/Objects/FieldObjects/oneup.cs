using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unilab2019.Objects.FieldItems
{
    class oneup : GameObject
    {
        public oneup(int x, int y) : base(x, y)
        {
            for (int i = 0; i < Bitmaps.Length; i++)
            {
                Bitmaps[i] = GetBitmap("character_cookie.png");
            }
        }
        public override void Draw(Graphics graphics, float width, float height)
        {
            if (!IsAlive) return;
            graphics.DrawImage(Bitmaps[(int)Direction], X * width, Y * height, width, height);
        }
    }
}
