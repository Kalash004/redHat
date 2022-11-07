using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat
{
    internal class Game
    {
        private bool playing = false;
        private Map map = null;
        public Game()
        {
            map = new Map();
            Console.WriteLine("map created");
            Console.WriteLine(map.ToString());
        }

        public void GameLoop()
        {
            // start game
            while (playing)
            {
                // game loop
            }
            // end game 
        }
    }
}
