using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    internal class GrannysHouse : Square
    {
        public GrannysHouse(Map map) : base(map)
        {
            display = "G";
            seen = true;
            base.visitable = true;
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
    }
}
