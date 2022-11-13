using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    internal class RedHatsHouse : Square
    {
        public RedHatsHouse(Map map) : base(map)
        {
            display = "H";
            base.playerOn = true;
        }

        public override bool Pass()
        {
            return true;
        }

        public override string ToString()
        {
            return display;
        }
    }
    
}
