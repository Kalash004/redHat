using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    /* 
     * WAYS TO GET THRU
     * 1) Answer a Question
     * 2) Random numbers fight
     */
    internal abstract class Square
    {
        //private int hard; // TODO: maybe implement hardcorness levels 
        protected string display; // How square is displayed
        protected string problem; // TODO: description / question to pass this location
        protected string answer; // TODO: answer to problem 
        protected bool playerOn; // Is player on this square
        protected bool seen = false; // Was this square seen or show ?
        protected bool visitable; // Can player come here


        public virtual string GenerateQuestionAnswer()
        {
            throw new NotImplementedException();
        }

        public abstract bool Pass();
            // TODO: Implement testing for answer / or number fight (choose a number if number is bigger than number from square and is not +3 bigger pass else stuck) 
            //if answered make it to give move options from Map
            //if didnt answer she gets stuck Call method from Game to ask for help.

        public override string ToString()
        {
            if (playerOn)
            {
                return "-o-";
            }
            else if (seen)
            {
                return display.ToString();
            }
            else
            {
                return "?";
            }
            /*
            return String.Format("Square name: {0}" +
                "Problem: {1} \n" +
                "Answer: {2} \n", name, problem, answer) ;
            */
        }




    }
}
