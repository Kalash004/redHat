using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat
{
    internal class Player
    {
        protected String name;
        protected int basket = 3; // items in basket

        public int Basket
        {
            get { return basket; } 
            set { basket = value;}
        }
    }
}
