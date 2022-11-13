using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    /// <summary>
    /// not done
    /// </summary>
    internal class Hunters : Square
    {
        public Hunters(Map map) : base(map)
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
