using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    internal class Lake : Square
    {
        private string display = "~";
        private bool visitable = false;
        private bool seen = false;


        public override bool Pass()
        {
            return false;
            // doesnt return anything coz player cant visit
        }

        public override string ToString()
        {
            return display;
        }
    }
}
