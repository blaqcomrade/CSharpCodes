// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello,how are you doing?");
while (true)
    {
    string num1;
    string num2;
    string op;
    Console.WriteLine("please enter two numbers"); 
    num1 = Console.ReadLine();
    num2 = Console.ReadLine();
    Console.WriteLine("select an operator +,-,*,/,%,^");
    op = Console.ReadLine();

    if (op == "+")
    {
        Console.WriteLine("the result is");
        Console.WriteLine(int.Parse(num1) + int.Parse(num2));
    }
    else if (op == "-")
    {
        Console.WriteLine("The result is");
        Console.WriteLine(int.Parse(num1) - int.Parse(num2));
    }
    else if (op == "*")
    {
        Console.WriteLine("The result is");
        Console.WriteLine(int.Parse(num1) * int.Parse(num2));
    }
    else if (op == "/")
    {
        Console.WriteLine("The result is");
        Console.WriteLine((decimal)int.Parse(num1) / int.Parse(num2));
    }
    else if (op == "%")
    {
        Console.WriteLine("The result is");
        Console.WriteLine(int.Parse(num1) % int.Parse(num2));
    }
    else if (op == "^")
    {
        Console.WriteLine("The result is");
        Console.WriteLine(Math.Sqrt(int.Parse(num1) + int.Parse(num2)));
    }
    else
    {
        Console.WriteLine("Enter a valid operator");
    }
}