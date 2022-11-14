using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace redHat.Squares
{

    /// <summary>
    /// You are asked question here, if you answer right, you can go away, if no you lose one item from basket.
    /// </summary>
    internal class Trap : Square
    {
        Dictionary<String,String> questions = new Dictionary<String,String>()
        {
            {"What two words every programmer learned to code first?","Hello World"},
            {"What is the most popular programming problem?","Missing a semicolon"},
            {"Where did programmers learn to program?","At Stackoverflow University"},
            {"What is the golden rule in programming?","If it works, don't touch it"},
            {"How do programmers enjoy life?","When they see their codes run without error"},
        };
        private String[] current_question;

        public Trap(Map map) : base(map)
        {
            display = "Trap";
            current_question = this.ChooseQuestion();
        }

        public override bool Activity()
        {
            Console.WriteLine("This square doesnt have any activity");
            return false;
        }

        public override string GenerateQuestionAnswer()
        {
            return base.GenerateQuestionAnswer();
        }

        public override bool Pass()
        {
            this.seen = true;
            bool returner = AskQuestion();
            this.passed = true;
            return returner;
        }
        
        private bool AskQuestion()
        {
            String? read = null;
            while (read == null)
            {
                Console.WriteLine(current_question[0]);
                read = Console.ReadLine();
            }
            if (read.Equals(current_question[1]))
            {
                return true;
            }
            Console.WriteLine("Your answer wasnt right, it will cost you an item from basket hehe");
            if (map.game.player.Basket > 0)
            {
                map.game.player.Basket = map.game.player.Basket - 1;
                Console.WriteLine("Yoink");
                return true;
            } else
            {
                Console.WriteLine("But you DONT HAVE any items in the basket, YOU ARE NOT LEAVING");
                map.game.GameLost();
                return false;
            }
        }
        private String[] ChooseQuestion()
        {
            Random rand = new();
            var val = rand.Next(0,questions.Count);
            return new String[] {questions.ElementAt(val).Key,questions.ElementAt(val).Value};
        }

       
    }
}
