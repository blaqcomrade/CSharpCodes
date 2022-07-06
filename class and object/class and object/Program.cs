namespace class_and_object
{
    class program
    {
        static void Main(string[] args)
        {
            QuizeQuestion Question1 = new QuizeQuestion();
            Question1.Question = "how many weeks are there in a month?";
            Question1.optionA = "2";
            Question1.optionB = "4";
            Question1.optionC = "3";
            Question1.optionD = "7";
            Question1.Answer = "4";
            Console.WriteLine(Question1.Question);

            QuizeQuestion Question2 = new QuizeQuestion();
            Question2.Question = "who was the president of Nigeria in the year 2014";
            Question2.optionA = "Goodluck jonathan";
            Question2.optionB = "Buhari";
            Question2.optionC = "Osibanjo";
            Question2.optionD = "Ortom";
            Question1.Answer = "Goodluck jonathan";
           
        }
    }
}