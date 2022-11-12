using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{
    internal class Trap : Square
    {
        Dictionary<String,String> questions = new Dictionary<String,String>()
        {
            {"What two words every programmer learned to code first? ","Hello World"},
            {"What is the most popular programming problem?","Missing a semicolon"},
            {"Where did programmers learn to program?","At Stackoverflow University."},
            {"What is the golden rule in programming?","If it works, don't touch it"},
            {"How do programmers enjoy life?","When they see their codes run without error."},
        };
        private String[] current_question;
        public override string GenerateQuestionAnswer()
        {
            return base.GenerateQuestionAnswer();
        }

        public override bool Pass()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return display;
        }

        private String[] generateQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
