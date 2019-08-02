﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unilab2019.Helpers;

namespace Unilab2019.Objects.FieldItems
{
    class Teleporter : GameObject
    {
        public int PairId { get; set; }

        public Types.Direction PlayerDirection { get; set; }

        public bool IsDestination { get; set; }

        public override bool CanMove { get; } = false;

        public Teleporter(int x, int y, int pairId, bool isDestination, Types.Direction? direction) : base(x, y)
        {
            PairId = pairId;
            IsDestination = isDestination;
            Direction = direction != null ? (Types.Direction)direction : Types.Direction.None;

            Bitmaps[0] = GetBitmap($"Teleporter_in{PairId}.jpg");
            Bitmaps[1] = GetBitmap($"Teleporter_out_{PairId}_up.jpg");
            Bitmaps[2] = GetBitmap($"Teleporter_out_{PairId}_down.jpg");
            Bitmaps[3] = GetBitmap($"Teleporter_out_{PairId}_right.jpg");
            Bitmaps[4] = GetBitmap($"Teleporter_out_{PairId}_left.jpg");
        }
        
        public override void Draw(Graphics graphics, float width, float height)
        {
            if (!IsAlive) return;
            graphics.DrawImage(Bitmaps[(int)Direction], X * width, Y * height, width, height);
        }
    }
}
