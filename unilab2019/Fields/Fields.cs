using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unilab2019.Objects;
using Unilab2019.Objects.Enemies;
using Unilab2019.Objects.Player;
using Unilab2019.Objects.Goal;
using Unilab2019.Objects.FieldItems;

namespace Unilab2019.Fields
{
    class Field
    {
        public Player Player { get; set; }
        public Goal Goal { get; set; }
        public List<Enemy> Enemies { get; set; } = new List<Enemy>();
        public List<Teleporter> Teleporters { get; set; } = new List<Teleporter>();
        public List<Wall> Walls { get; set; } = new List<Wall>();
        public int Width { get; set; }
        public int Height { get; set; }
        public string StageName { get; set; }

        public List<GameObject> GameObjectList()
        {
            List<GameObject> objs = new List<GameObject>();
            objs.Add(Player);
            objs.Add(Goal);
            objs.AddRange(Enemies);
            objs.AddRange(Teleporters);
            objs.AddRange(Walls);
            return objs;
        }
    }
}
