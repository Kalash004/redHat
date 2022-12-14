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
        protected int X = 7, Y = 3; // current map dimensions 
        protected Square[,] game_map;
        protected int[] player_pos;
        protected int[] wolf_pos;
        protected Wolf wolf;
        public Game game;
        public Map(Game game)
        {
            this.game = game;
            this.wolf = new Wolf(this);
            this.game_map = GenerateMap();
        }

        public Wolf Wolf_Npc
        {
            get { return wolf; }
            set { wolf = value; }
        }

        public Square[,] GameMap
        {
            get { return game_map; }
        }
        public int getX
        {
            get { return X; }
        }

        public int getY
        {
            get { return Y; }
        }
        public int[] PlayerPos
        {
            get { return player_pos; }
            set { player_pos = value; }
        }

        public int[] WolfPos
        {
            get { return wolf_pos; }
            set { wolf_pos = value; }
        }

        public bool Move(int val)
        {
            int[] next_loc = null;
            Square next_sqr;
            switch (val)
            {
                case 1: // Right might add enum if have time
                    next_loc = new int[] { player_pos[0], player_pos[1] + 1 };
                    break;
                case 2: // Front
                    next_loc = new int[] { player_pos[0] - 1, player_pos[1] };
                    break;
                case 3: // Left
                    next_loc = new int[] { player_pos[0], player_pos[1] - 1 };
                    break;
                case 4:  // Back
                    next_loc = new int[] { player_pos[0] + 1, player_pos[1] };
                    break;
            }
            if (next_loc[0] < 0 || next_loc[0] > X - 1 || next_loc[1] < 0 || next_loc[1] > Y - 1)
            {
                Console.WriteLine("You cant get out of the map");
                return game.Move();
            }
            if (next_loc != null && game_map[next_loc[0], next_loc[1]] != null)
            {
                next_sqr = game_map[next_loc[0], next_loc[1]];
                if (next_sqr.Visitable)
                {
                    game.player.CurrentLocation.PlayerOn = false;
                    game.player.CurrentLocation = next_sqr;
                    this.player_pos = next_loc;
                    game.player.CurrentLocation.PlayerOn = true;
                    return true;
                }
                else
                {
                    Console.WriteLine("You cant visit that location");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Please re enter the location");
                return game.Move();
            }
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
                    int val = rand.Next(1, 9); // maybe add some posibility of different squares
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
                            Square wolf_cave = new Wolf_Cave(this, this.wolf,new int[] {i,j});
                            map_generation[i, j] = wolf_cave;
                            break;

                        //case 3: // grannys house
                        //    Square granny = new GrannysHouse(this);
                        //    map_generation[i, j] = granny;
                        //    break;

                        //case 4: // red hats house
                        //    Square hat_house = new RedHatsHouse(this);
                        //    map_generation[i, j] = hat_house;
                        //    break;

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

                        //case 8: // hunters
                        //    Square hunter = new Hunters(this);
                        //    map_generation[i, j] = hunter;
                        //    break;

                        default:
                            Square field2 = new MushroomField(this);
                            map_generation[i, j] = field2;
                            break;

                    }
                    // generate column values(add level auto generations [traps and other stuff]);
                }
            }
            Square home = new RedHatsHouse(this);
            Square granny = new GrannysHouse(this);
            map_generation[X - 1, Y / 2] = home;
            map_generation[0, Y / 2] = granny;
            game.player.CurrentLocation = home;
            player_pos = new int[] { X - 1, Y / 2 };
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

        public void ShowMap()
        {
            Console.WriteLine(ToString());
        }

        public bool MoveToRandom()
        {
            Random rand = new();
            Square sqr = null;
            bool reachable = false;
            int[] next_loc = null;
            while (!reachable)
            {
                int x = rand.Next(0, X);
                int y = rand.Next(0, Y);
                sqr = game_map[x, y];
                if (sqr.Visitable)
                {
                    next_loc = new int[] { x, y };
                    reachable = true;
                }
            }
            game.player.CurrentLocation.PlayerOn = false;
            game.player.CurrentLocation = sqr;
            player_pos = next_loc;
            game.player.CurrentLocation.PlayerOn = true;
            return true;
        }
        public bool CheckAround(int i)
        {
            for (int j = 1; j < i; j++)
            {
                int[] next_loc = new int[] { player_pos[0], player_pos[1] + j };
                if (next_loc[0] >= 0 && next_loc[0] <= X - 1 && next_loc[1] >= 0 && next_loc[1] <= Y - 1)
                {
                    Square next_sqr = game_map[next_loc[0], next_loc[1]];
                    next_sqr.Seen = true;
                }
                next_loc = new int[] { player_pos[0], player_pos[1] - j };
                if (next_loc[0] >= 0 && next_loc[0] <= X - 1 && next_loc[1] >= 0 && next_loc[1] <= Y - 1)
                {
                    Square next_sqr = game_map[next_loc[0], next_loc[1]];
                    next_sqr.Seen = true;
                }
                next_loc = new int[] { player_pos[0] + j, player_pos[1] };
                if (next_loc[0] >= 0 && next_loc[0] <= X - 1 && next_loc[1] >= 0 && next_loc[1] <= Y - 1)
                {
                    Square next_sqr = game_map[next_loc[0], next_loc[1]];
                    next_sqr.Seen = true;
                }
                next_loc = new int[] { player_pos[0] - j, player_pos[1] };
                if (next_loc[0] >= 0 && next_loc[0] <= X - 1 && next_loc[1] >= 0 && next_loc[1] <= Y - 1)
                {
                    Square next_sqr = game_map[next_loc[0], next_loc[1]];
                    next_sqr.Seen = true;
                }
            }
            return true;
        }
    }
}
