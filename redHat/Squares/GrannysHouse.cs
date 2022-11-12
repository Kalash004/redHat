using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    internal class GrannysHouse : Square
    {
        public GrannysHouse(Map map) : base(map)
        {
        }

        public override bool Pass()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return display;
        }
    }
}
