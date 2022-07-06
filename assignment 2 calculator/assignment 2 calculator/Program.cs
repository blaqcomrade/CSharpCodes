// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter first number");
string num1 = Console.ReadLine();
Console.WriteLine("enter second number");
string num2 = Console.ReadLine();
Console.WriteLine("enter third number");
string num3 = Console.ReadLine();
Console.WriteLine("enter fourth number");
string num4 = Console.ReadLine();
int answer = ((int.Parse(num1) + int.Parse(num2)) * int.Parse(num3) - int.Parse(num4));
Console.WriteLine("enter fifth number");
string num5 = Console.ReadLine();
Console.WriteLine(answer / int.Parse(num5));

