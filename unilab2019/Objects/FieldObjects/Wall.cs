using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unilab2019.Objects.FieldItems
{
    class Wall : GameObject
    {
        public int ImageType { get; set; }
        public override bool CanMove { get; } = false;
        public Wall(int x, int y, int imageType) : base(x, y)
        {
            ImageType = imageType;
            for (int i = 0; i < Bitmaps.Length; i++)
            {
                Bitmaps[i] = GetBitmap("Wall.jpg");
            }
        }

        public override void Draw(Graphics graphics, float width, float height)
        {
            if (!IsAlive) return;
            graphics.DrawImage(Bitmaps[(int)Direction], X * width, Y * height, width, height);
        }
    }
}
