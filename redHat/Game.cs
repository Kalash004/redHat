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
            player = new Player();
            playing = true;
        }

        public void GameLoop()
        {
            // start game
            Console.WriteLine("Welcome to RedHat game alpha \n" +
                "You are in your house and your objective is to get items in your basket to your grandmas house \n" +
                "Here is map, you can only see places that are near you, to find out about other places you have to come near to them (1 square around):");
            map.ShowMap();
            int i = 1;
            while (playing)
            {
                // game loop
                Console.WriteLine("Current round :" + i);
                map.ShowMap();
                player.CurrentLocation.Pass();
                GameMenu();
                i++;
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
                    player.CurrentLocation.Activity();
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

    }
}
