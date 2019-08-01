using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Unilab2019.Helpers
{
    public static class Types
    {
        public enum Instruction { IfCode, ForCode, WhileCode, Forward, Backward, Right, Left, End }
        public enum Direction { None, Up, Down, Right, Left }
        public enum Obj { Wall, Enemy, Road }
    }
    public class Code {
        /// <summary>
        /// if,for,while
        /// </summary>
        public Types.Instruction Instruction { get; set; }

        /// <summary>
        /// forの場合の繰りかえし回数
        /// </summary>
        public int Repeat_num { get; set; }

        public Types.Direction Diriection { get; set; }
        /// <summary>
        /// Wall,Enemy,Road
        /// </summary>
        public Types.Obj Obj { get; set; }

        public int Indent { get; set; }

    }
}