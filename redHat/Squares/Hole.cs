using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    internal class Hole : Square
    {
        public Hole(Map map) : base(map)
        {
            this.display = "Hole";
        }

        public override bool Pass()
        {
            this.passed = true;
            map.ShowMap();
            return map.MoveToRandom();
        }
     
    }
}
