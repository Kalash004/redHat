using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using redHat.Squares;

namespace redHat
{
    internal class Player
    {
        protected int starting_basket = 1;
        protected String name = "RH";
        protected int basket; // items in basket
        protected Square current_location;

        public Player()
        {
            basket = starting_basket;
        }
        public int Basket
        {
            get { return basket; } 
            set { basket = value;}
        }
        
        public int StartingB
        {
            get { return starting_basket; }
        }

        public String Name
        {
            get { return name; }  
            set { name = value; }
        }

        public Square CurrentLocation
        {
            get { return current_location; }
            set { current_location = value;}
        }
    }
}
