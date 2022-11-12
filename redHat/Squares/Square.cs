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
    internal class Square
    {
        private int hard; // TODO: maybe implement hardcorness levels 
        private string name;
        private string problem; // TODO: description / question to pass this location
        private string answer; // TODO: answer to problem 
        private bool playerOn;
        private bool seen = false;
        public Square()
        {

        }

        public Square(string name, string problem, string answer, bool playerOn)
        {
            this.name = name;
            this.problem = problem;
            this.answer = answer;
            this.playerOn = playerOn;
        }

        public virtual string GenerateQuestionAnswer()
        {
            throw new NotImplementedException();
        }

        public virtual bool Pass(string ans)
        {
            // TODO: Implement testing for answer / or number fight (choose a number if number is bigger than number from square and is not +3 bigger pass else stuck) 
            //if answered make it to give move options from Map
            //if didnt answer she gets stuck Call method from Game to ask for help.
            throw new NotImplementedException();
        }




        public override string ToString()
        {
            if (playerOn)
            {
                return "-o-";
            }
            else if (seen)
            {
                return name.ToString();
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
