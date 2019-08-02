using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Unilab2019.Helpers
{
    public static class Types
    {
        public enum Instruction { IfCode, ForCode, WhileCode, Forward, TurnRight, TurnLeft, End, Stop, None}
        public enum Direction { None, Up, Down, Right, Left, Forward, Backward }
        public enum Obj { Wall, Enemy, Road ,None}
    }
    public class Code {
        /// <summary>
        /// if,for,while
        /// </summary>
        public Types.Instruction Instruction { get; set; } = Types.Instruction.None;

        /// <summary>
        /// forの場合の繰りかえし回数
        /// </summary>
        public int Repeat_num { get; set; } = 0;

        public Types.Direction Direction { get; set; } = Types.Direction.None;
        /// <summary>
        /// Wall,Enemy,Road
        /// </summary>
        public Types.Obj Obj { get; set; } = Types.Obj.None;

        public int Indent { get; set; } = 0;

    }
}