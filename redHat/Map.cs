using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat
{
    internal class Map
    {
        private int X = 5, Y = 5; // current map dimensions 
        private Square[,] game_map;
        public Map()
        {
            this.game_map = GenerateMap();

        }


        // maybe in future game hardness (bigger map ?)
        public Square[,] GenerateMap()
        {
            Square[,] map_generation = new Square[X,Y];
            Console.WriteLine("Generating map");
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    // generate column values(add level auto generations [traps and other stuff]);
                    Square sqr = new Square(i.ToString()+j.ToString(), "f", "f");
                    map_generation[i, j] = sqr;
                }
            }
            return map_generation;
        }

        public bool RegenerateMap()
        {
            game_map = GenerateMap();
            return true;
        }

        public override string ToString()
        {
            String returner = "";
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    returner = returner + game_map[i, j].ToString() + "\t";
                }
                returner = returner + "\n\n";
            }
            return returner;
        }
    }
}
