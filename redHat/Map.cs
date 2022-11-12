using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using redHat.Squares;

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
        public Game game;
        public Map(Game game)
        {
            this.game_map = GenerateMap();
            this.game = game;
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
                    int val = rand.Next(1, 2); // maybe add some posibility of different squares
                    switch (val)
                    {
                        case 0: // lake
                            Square sqr = new Lake(this);
                            map_generation[i, j] = sqr;
                            break;

                        case 1: // trap
                            Square trap = new Trap(this);
                            map_generation[i, j] = trap;
                            break;

                        case 2: // wolf
                            Square wolf = new Wolf(this);
                            map_generation[i, j] = wolf;
                            break;

                        case 3: // grannys house
                            Square granny = new GrannysHouse(this);
                            map_generation[i, j] = granny;
                            break;

                        case 4: // red hats house
                            Square hat_house = new RedHatsHouse(this);
                            map_generation[i, j] = hat_house;
                            break;

                        case 5: // hill 
                            Square hill = new Hill(this);
                            map_generation[i, j] = hill;
                            break;

                        case 6: // hole
                            Square hole = new Hole(this);
                            map_generation[i, j] = hole;
                            break;

                        case 7: // field
                            Square field = new MushroomField(this);
                            map_generation[i, j] = field;
                            break;

                        case 8: // hunters
                            Square hunter = new Hunters(this);
                            map_generation[i, j] = hunter;
                            break;

                    }
                    // generate column values(add level auto generations [traps and other stuff]);
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
