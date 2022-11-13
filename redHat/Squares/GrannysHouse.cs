using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
        /// <summary>
        /// Finish line, if you have enough items in basket you win, if no you can go back and get some items
        /// </summary>
    internal class GrannysHouse : Square
    {
        /// <param name="map"> map </param>
        public GrannysHouse(Map map) : base(map)
        {
            display = "Granny";
            seen = true;
            base.playerOn = false;
        }

        public override bool Pass()
        {
            if (map.game.player.Basket > 0)
            {
                Console.WriteLine("You win, you brought " + map.game.player.Basket + " items to your granny");
                map.game.GameWon();
                passed = true;
                return true;
            } else
            {
                Console.WriteLine("You dont have any items to give to the granny, go get some !");
                passed = false;
                return false;
            }
        }

        public override bool Activity()
        {
            Console.WriteLine("This square doesnt have any activity");
            return false;
        }
    }
}
