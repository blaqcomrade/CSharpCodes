namespace class_method
{
    class program
    {
        static void Main(string[] args)
        {

            List<QuizeQuestion> question = new List<QuizeQuestion>()
            {
                new QuizeQuestion("how many weeks are there in a month?","2","4","3","7","b"),
                new QuizeQuestion("who was the president of Nigeria in the year 2014","Goodluck jonathan","Buhari","Osibanjo", "Ortom","a"),
                new QuizeQuestion("how many days are there in a week", "3", "5", "7", "4", "c"),
            };

            int totalgrade = 0;

            foreach (var objects in question)
            {
                AskQuestion(objects);
                totalgrade += checkAnswer(objects.Answer);
              
            }

            Console.WriteLine("YOUR RESULT IS: " + totalgrade);

            static int checkAnswer(string correctAnswer)
            {
                string answer = Console.ReadLine();
                if (answer.Equals(correctAnswer, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("PASS! You have gotten 1 point.");
                        return 1;
                }
                else
                {
                    Console.WriteLine("FAILED");
                    return 0;
                }
            }

            //static int addnumber(int x)
            //   {
            //       return x;
            //   }
            //   addnumber(10);

            //   static void add()
            //   {
            //       Console.WriteLine(7);
            //   }

            static void AskQuestion(QuizeQuestion question)
            {
                Console.WriteLine(question.Question);
                Console.WriteLine("a " + question.optionA);
                Console.WriteLine("b " + question.optionB);
                Console.WriteLine("c " + question.optionC);
                Console.WriteLine("d  " + question.optionD);
                Console.WriteLine("Enter Option");
            }


            //QuizeQuestion Question1 = new QuizeQuestion();
            //Question1.Question = "how many weeks are there in a month?";
            //Question1.optionA = "2";
            //Question1.optionB = "4";
            //Question1.optionC = "3";
            //Question1.optionD = "7";
            //Question1.Answer = "4";
            //Console.WriteLine(Question1.Question);

            //QuizeQuestion Question2 = new QuizeQuestion();
            //Question2.Question = "who was the president of Nigeria in the year 2014";
            //Question2.optionA = "Goodluck jonathan";
            //Question2.optionB = "Buhari";
            //Question2.optionC = "Osibanjo";
            //Question2.optionD = "Ortom";
            //Question1.Answer = "Goodluck jonathan";


            //QuizeQuestion Question3 = new QuizeQuestion("how many days are there in a week", "3", "5", "7", "4", "7");
            //Console.WriteLine(Question3.Question);
        }
    }
}