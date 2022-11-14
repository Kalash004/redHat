using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    /// <summary>
    /// Replenish your basket
    /// </summary>
    internal class MushroomField : Square
    {
        private bool activated = false;
        public MushroomField(Map map) : base(map)
        {
            display = "Field";
            seen = false;
        }

        public override bool Pass()
        {
            this.passed = true;
            return true;
        }

        public override bool Activity()
        {
            if (!activated)
            {
                Random random = new();
                int rand = random.Next(1, 4);
                map.game.player.Basket = map.game.player.Basket + rand;
                Console.WriteLine("You have taken " + rand + " Mushrooms from the field");
                activated = true;
            } else
            {
                Console.WriteLine("You cant take more from here");
            }
            return true;
        }

    }
}
