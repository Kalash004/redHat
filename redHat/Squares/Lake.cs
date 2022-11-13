using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    /// <summary>
    /// You cant come here
    /// </summary>
    internal class Lake : Square
    {

        public Lake(Map map) : base(map)
        {
            display = "~";
            seen = false;
        }

        public override bool Pass()
        {
            return false;
            // doesnt return anything coz player cant visit
        }

    
    }
}
