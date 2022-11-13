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
        protected String name = "RedHat";
        protected int basket = 1; // items in basket
        protected Square current_location;

        public int Basket
        {
            get { return basket; } 
            set { basket = value;}
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
