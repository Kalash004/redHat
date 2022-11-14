using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    /// <summary>
    /// Hole transports you one time to different place
    /// </summary>
    internal class Hole : Square
    {
        public Hole(Map map) : base(map)
        {
            this.display = "Hole";
        }

        public override bool Pass()
        {
            passed = true;
            map.MoveToRandom();
            map.ShowMap();
            return true;
        }

    }
}
