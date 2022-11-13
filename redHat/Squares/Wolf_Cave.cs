using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    /// <summary>
    /// Spawn Wolf
    /// </summary>
    internal class Wolf_Cave : Square
    {
        private int[] loc;
        private Wolf wolf;

        public Wolf_Cave(Map map, Wolf wolf, int[] loc) : base(map)
        {
            display = "Cave";
            this.wolf = wolf;
            this.loc = loc;
        }

        public override bool Pass()
        {
            Console.WriteLine("Wolf started hunting your granny, get to her first");
            wolf.Spawned = true;
            map.WolfPos = loc;
            this.seen = true;
            return true;
        }
    }
}
