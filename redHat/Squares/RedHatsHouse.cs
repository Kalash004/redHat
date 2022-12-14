using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    /// <summary>
    /// Starting line, you can replenish your basket one time if you come back here
    /// </summary>
    internal class RedHatsHouse : Square
    {
        public RedHatsHouse(Map map) : base(map)
        {
            display = "Home";
            base.playerOn = true;
        }
        private bool refilled;
        public override bool Pass()
        {
            return true;
            this.passed = true;
            this.seen = true;
        }

        public override bool Activity()
        {
            if (!refilled)
            {
                Console.WriteLine("You have replenished your basket");
                map.game.player.Basket = map.game.player.StartingB;
                refilled = true;
                return true;
            } else
            {
                Console.WriteLine("Are you eating all of it, you cant have any !");
                return false;
            }
        }

    }

}
