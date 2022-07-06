// See https://aka.ms/new-console-template for more information
namespace WorldGuesAPPP
{
    class Game
    {
        int Guess = 0;
        int Target = 5;
        string Input = ""; 
        string[] words = { "cat", "hat", "rat" };
        Random RandomNumber = new Random();
        public void Play()
        {
            Target = RandomNumber.Next(words.Length);

            Console.WriteLine("Guess which word i am thinking of..... is it ");
            for (int i = 0; i < words.Length; i++)
            {
                if (i == (words.Length - 1))
                    Console.Write("or " + words[i] + "? ");
                else
                    Console.Write(words[i] + ", ");

                Input = Console.ReadLine();
                if (Input == words[Target])
                {
                    Console.WriteLine("Congratulation! You guessed it");
                }
                else
                {
                    Console.WriteLine("Not a match. Try Again!");
                    Console.WriteLine("Press Enter to contiune....");
                    Play();
                }

                Console.ReadKey();

            }
        }
    }
}