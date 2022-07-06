// See https://aka.ms/new-console-template for more information
Dictionary<int, string> data = new Dictionary<int, string>();
data.Add(1234, "1234");
data.Add(5678, "5678");
data.Add(3456, "3456");
data.Add(789, "789");

int total = 0;
for (int i = 1; i <=2; i++)

Console.WriteLine("Quize app");
Console.WriteLine("please enter your exam number");
string login = Console.ReadLine();


if (login == "1234" || login == "5678" || login == "3456" || login == "789")

{
    Console.WriteLine("login successful");
    Console.WriteLine("You are to answer all question");

    Dictionary<int, string> answer = new Dictionary<int, string>();
    answer.Add(1, "a. 5");
    answer.Add(2, "b. 10");
    answer.Add(3, "c. 7");
    answer.Add(4, "d. 4");

    Dictionary<string, int> scores = new Dictionary<string, int>();

    string input;


    Console.WriteLine("Q1.) how many days are there in 1 week?");
    for (int i = 1; i <= answer.Count; i++)
    {
        Console.WriteLine(answer[i]);
    }

    Console.WriteLine("SELECT AN OPTION");
    input = Console.ReadLine();

    if (input == "c")
    {
        Console.WriteLine("CORRECT");
        
        Console.WriteLine("YOU GOT 2 POINTS");
        
    }
    else
    {
        Console.WriteLine("WRONG");
    }

    //next question


    Dictionary<int, string> answer1 = new Dictionary<int, string>();
    answer1.Add(1, "a. 10");
    answer1.Add(2, "b. 30");
    answer1.Add(3, "c. 15");
    answer1.Add(4, "d. 36");


    Console.WriteLine("Q2.) how many state are there in Nigeria?");
    for (int i = 1; i <= answer1.Count; i++)
    {
        Console.WriteLine(answer1[i]);
    }

    Console.WriteLine("SELECT AN OPTION");
    input = Console.ReadLine();

    if (input == "d")
    {
        Console.WriteLine("CORRECT");
        Console.WriteLine("YOU GOT 2 POINTS");
        scores.Add("d", 2);
    }
    else
    {
        Console.WriteLine("WRONG");
    }


    //next question

    Dictionary<int, string> answer2 = new Dictionary<int, string>();
    answer2.Add(1, "a. SAMUEL");
    answer2.Add(2, "b. DANIEL");
    answer2.Add(3, "c. PATRICK");
    answer2.Add(4, "d. OBED");


    Console.WriteLine("Q3.) what is the name of your instructor?");
    for (int i = 1; i <= answer2.Count; i++)
    {
        Console.WriteLine(answer2[i]);
    }

    Console.WriteLine("SELECT AN OPTION");
    input = Console.ReadLine();

    if (input == "b")
    {
        Console.WriteLine("CORRECT");
        Console.WriteLine("YOU GOT 2 POINTS");
        scores.Add("b", 2);
    }
    else
    {
        Console.WriteLine("WRONG");
    }

    //next question


    Dictionary<int, string> answer3 = new Dictionary<int, string>();
    answer3.Add(1, "a. BUHARI");
    answer3.Add(2, "b. ORTOM");
    answer3.Add(3, "c. JONATHAN");
    answer3.Add(4, "d. PATOO");


    Console.WriteLine("Q4.) Who is the president of NIGERIA?");
    for (int i = 1; i <= answer3.Count; i++)
    {
        Console.WriteLine(answer3[i]);
    }

    Console.WriteLine("SELECT AN OPTION");
    input = Console.ReadLine();

    if (input == "a")
    {
        Console.WriteLine("CORRECT");
        Console.WriteLine("YOU GOT 2 POINTS");
        scores.Add("a", 2);
    }
    else
    {
        Console.WriteLine("WRONG");
    }

    //next question
    Dictionary<int, string> answer4 = new Dictionary<int, string>();
    answer4.Add(1, "a. PHYSICS");
    answer4.Add(2, "b. LIT-IN-ENGLISH");
    answer4.Add(3, "c. CHEMISTRY");
    answer4.Add(4, "d. BIOLOGY");



    Console.WriteLine("Q5.) which of the following is not a science subject?");
    for (int i = 1; i <= answer4.Count; i++)
    {
        Console.WriteLine(answer4[i]);
    }

    Console.WriteLine("SELECT AN OPTION");
    input = Console.ReadLine();

    if (input == "b")
    {
        Console.WriteLine("CORRECT");
        Console.WriteLine("YOU GOT 2 POINTS");
        scores.Add("e", 2);
    }
    else
    {
        Console.WriteLine("WRONG");
    }
    Console.WriteLine("TOTAL SCORE");
    var total = scores.Sum(x => x.Value);
    Console.WriteLine(total);
}
else
{
    Console.WriteLine("invalid user");
}

    








