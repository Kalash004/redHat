using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    /// <summary>
    /// Class Base for other places
    /// </summary>
    internal class Square
    {
        //private int hard; // TODO: maybe implement hardcorness levels 
        protected string display; // How square is displayed
        protected bool playerOn; // Is player on this square
        protected bool seen = false; // Was this square seen or show ?
        protected bool visitable = true; // Can player come here
        protected Map map;
        protected bool passed;
        protected bool wolfOn = false;

        public Square(Map map)
        {
            this.map = map;
        }

        public bool Seen
        {
            get { return this.seen; }
            set { this.seen = value; }
        }
        public bool Visitable
        {
            get { return visitable; }
            set { visitable = value; }
        }

        public bool Passed
        {
            get { return this.passed; }
            set { this.passed = value; }
        }

        public bool PlayerOn
        {
            get { return playerOn; }
            set { playerOn = value; }
        }

        public bool WolfOn
        {
            get { return wolfOn; }
            set { wolfOn = value; }
        }

        public virtual string GenerateQuestionAnswer()
        {
            throw new NotImplementedException();
        }

        public virtual bool Activity()
        {
            return false;
        }

        public virtual bool Pass()
        {
            throw new NotImplementedException();
        }
        // TODO: Implement testing for answer / or number fight (choose a number if number is bigger than number from square and is not +3 bigger pass else stuck) 
        //if answered make it to give move options from Map
        //if didnt answer she gets stuck Call method from Game to ask for help.

        public override string ToString()
        {
            String returner;
            if (seen)
            {
                returner = display;
            }
            else
            {
                returner = "?";
            }
            if (playerOn && wolfOn)
            {
                returner = map.game.player.Name + " + " + map.Wolf_Npc.Display;
            }
            else if (wolfOn)
            {
                returner = map.Wolf_Npc.Display;
            }
            else if (playerOn)
            {
                returner = map.game.player.Name;
            }
            return returner;
            /*
            return String.Format("Square name: {0}" +
                "Problem: {1} \n" +
                "Answer: {2} \n", name, problem, answer) ;
            */
        }




    }
}
