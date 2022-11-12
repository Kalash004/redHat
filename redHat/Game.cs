using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace redHat
{
    internal class Game
    {
        private bool playing = false;
        private Map map = null;
        public Player player;
        public Game()
        {
            map = new Map(this);
            Console.WriteLine("map created");
            Console.WriteLine(map.ToString());
            player = new Player();
            Console.WriteLine("player created");
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

        public void GameLost()
        {
            this.playing = false;
            Console.WriteLine("Game lost"); // maybe add some info at the end
        }

        public void GameMenu()
        {

        }

    }
}
