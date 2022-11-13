using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    internal class Hill : Square
    {
        public Hill(Map map) : base(map)
        {
            this.display = "Hill";
            this.seen = true;

        }

        public override bool Pass()
        {
            return true;
        }

        public override bool Activity()
        {
            Console.WriteLine("You looked around from hill");
            map.CheckAround(3);
            map.ShowMap();
            return true;
        }

    }
}
