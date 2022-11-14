using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using redHat.Squares;

namespace redHat
{
    internal class Wolf
    {
        private String display = "WOLF";
        protected bool spawned = false;
        protected Map map;

        public Wolf(Map map)
        {
            this.map = map;
        }
        public String Display
        {
            get { return display; }
        }
        public bool Spawned
        {
            get { return spawned; }
            set { spawned = value; }
        }

        public void roundFinish()
        {
            throw new NotImplementedException();
        }

        internal void Hunt()
        {
            int[] cur_wolf_pos = map.WolfPos;
            Square sqr;
            if (cur_wolf_pos[0] == 0)
            {
                if (cur_wolf_pos[1] != map.getY / 2)
                {
                    if (cur_wolf_pos[1] < map.getY / 2)
                    {
                        sqr = map.GameMap[cur_wolf_pos[0], cur_wolf_pos[1]];
                        sqr.WolfOn = false;
                        int[] pos = new int[] { cur_wolf_pos[0], cur_wolf_pos[1] + 1 };
                        sqr = map.GameMap[pos[0],pos[1]];
                        map.WolfPos = pos;
                        sqr.WolfOn = true;
                    }
                    else
                    {
                        sqr = map.GameMap[cur_wolf_pos[0], cur_wolf_pos[1]];
                        sqr.WolfOn = false;
                        int[] pos = new int[] { cur_wolf_pos[0], cur_wolf_pos[1] - 1 };
                        sqr = map.GameMap[pos[0], pos[1]];
                        map.WolfPos = pos;
                        sqr.WolfOn = true;
                    }
                }
                else
                {
                    Console.WriteLine("Your grandma got eaten by a Wolf ;-;");
                    map.game.GameLost();
                }
            }
            else
            {
                sqr = map.GameMap[cur_wolf_pos[0], cur_wolf_pos[1]];
                
                sqr.WolfOn = false;
                int[] pos = new int[] { cur_wolf_pos[0] - 1, cur_wolf_pos[1] };
                sqr = map.GameMap[pos[0], pos[1]];
                map.WolfPos = pos;
                sqr.WolfOn = true;
            }
        }
    }
}