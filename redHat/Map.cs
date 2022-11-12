using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace redHat
{
    public enum SquareTypes
    {
        Trap, // asks a question, if you dont answer you lose 1 item from basket
        Wolf, // starts to go to the granny after 2 moves (if you need to obtain some items for granny he will be faster?)
        GrannyHouse, // end
        RedHatHouse, // start
        Hill, // can check surrounding places 2 squares around
        Hole, // transports to random position
        MushroomField, // you can get some stuff for your granny
        Hunters, // if you find them and there is a wolf hunting granny, they will hunt him down
        Lake, // you cant pass this
    }
    internal class Map
    {
        protected int X = 5, Y = 5; // current map dimensions 
        protected Square[,] game_map;
        protected Square player_pos;
        public Map()
        {
            this.game_map = GenerateMap();

        }


        // maybe in future game hardness (bigger map ?)
        public Square[,] GenerateMap()
        {
            Square[,] map_generation = new Square[X, Y];
            Console.WriteLine("Generating map");
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    Random rand = new Random();
                    int val = rand.Next(0, 9); // maybe add some posibility of different squares
                    switch (val)
                    {
                        case 0: // lake
                            Square sqr = new Lake();
                            map_generation[i, j] = sqr;

                            break;

                        case 1: // trap
                            map_generation[i, j] = sqr;

                            break;

                        case 2: // wolf
                            map_generation[i, j] = sqr;

                            break;

                        case 3: // grannys house
                            map_generation[i, j] = sqr;

                            break;

                        case 4: // red hats house
                            map_generation[i, j] = sqr;

                            break;

                        case 5: // hill 
                            map_generation[i, j] = sqr;

                            break;

                        case 6: // hole
                            map_generation[i, j] = sqr;

                            break;

                        case 7: // field
                            map_generation[i, j] = sqr;

                            break;

                        case 8: // hunters
                            map_generation[i, j] = sqr;

                            break;

                    }
                    // generate column values(add level auto generations [traps and other stuff]);
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
