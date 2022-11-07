using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat
{
    /* 
     * WAYS TO GET THRU
     * 1) Answer a Question
     * 2) Random numbers fight
     */
    internal class Square
    {
        private int hard; // TODO: maybe implement hardcorness levels 
        private String name;
        private String problem; // TODO: description / question to pass this location
        private String answer; // TODO: answer to problem 
        public Square()
        {

        }

        public Square(string name, string problem, string answer)
        {
            this.name = name;
            this.problem = problem;
            this.answer = answer;
        }

        public virtual String GenerateQuestionAnswer()
        {
            throw new NotImplementedException();  
        }

        public virtual bool Pass(String ans)
        {
            // TODO: Implement testing for answer / or number fight (choose a number if number is bigger than number from square and is not +3 bigger pass else stuck) 
            //if answered make it to give move options from Map
            //if didnt answer she gets stuck Call method from Game to ask for help.
            throw new NotImplementedException();
        }




        public override string ToString()
        {
            return name.ToString();
            /*
            return String.Format("Square name: {0}" +
                "Problem: {1} \n" +
                "Answer: {2} \n", name, problem, answer) ;
            */
        }




    }
}
