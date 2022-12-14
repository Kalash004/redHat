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
            player = new Player();
            map = new Map(this);
            playing = true;
        }

        public void GameLoop()
        {
            // start game
            Console.WriteLine("Welcome to RedHat game alpha \n" +
                "You are in your house and your objective is to get items in your basket to your grandmas house \n" +
                "Here is map, you can only see places that are near you, to find out about other places you have to come near to them (1 square around):");
            int i = 1;
            while (playing)
            {
                // game loop
                Console.WriteLine("Current round :" + i);
                CheckAround();
                map.ShowMap();
                if (!player.CurrentLocation.Passed)
                {
                    player.CurrentLocation.Pass();
                }
                if (playing)
                {
                    GameMenu();
                }
                bool wolfspawn = false;
                if (map.Wolf_Npc.Spawned)
                {
                    if (!wolfspawn)
                    {
                        wolfspawn = true;
                    }
                    map.Wolf_Npc.Hunt();
                }
                i++;
            }
            // end game 
            Console.WriteLine("Thanks for playing Alpha version of RedHat game");
        }

        public void GameLost()
        {
            this.playing = false;
            Console.WriteLine("Game lost"); // maybe add some info at the end
        }

        public void GameWon()
        {
            this.playing  = false;
            Console.WriteLine("Game won nice !");
        }

        public void GameMenu()
        {
            int? choose = null;
            while (choose == null || choose < 1 && choose > 4)
            {
                Console.WriteLine("Choose option : \n" +
                    "1) Move \n" +
                    "2) Square activity \n");
                choose = int.Parse(Console.ReadLine()); // FIX: add null catcher 
            }
            switch (choose)
            {
                case 1:
                    Move();
                    break;
                case 2:
                    if(!player.CurrentLocation.Activity())
                    {
                        GameMenu();
                    }
                    break;
            }
        }

        public bool Move()
        {
            int? choose = null;
            while (choose == null || choose < 1 && choose > 4)
            {
                Console.WriteLine("1) Right \n" +
                    "2) Front \n" +
                    "3) Left \n" +
                    "4) Back \n");
                choose = int.Parse(Console.ReadLine()); // FIX: add null catcher 
            }
            return map.Move((int)choose);
        }

        public bool CheckAround()
        {
            return map.CheckAround(2);
        }

    }
}
