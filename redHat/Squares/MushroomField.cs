using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    internal class MushroomField : Square
    {
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
            Random random = new();
            int rand = random.Next(1,4);
            map.game.player.Basket = map.game.player.Basket + rand;
            Console.WriteLine("You have taken " + rand + " Mushrooms from the field");
            return true;
        }

    }
}
