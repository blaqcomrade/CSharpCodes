try
{
    string num1;
    string num2;

    Console.WriteLine("enter first number");
    num1 = Console.ReadLine();
    Console.WriteLine("enter second number");
    num2 = Console.ReadLine();

    Console.WriteLine("Answer");
    Console.WriteLine((decimal)int.Parse(num1) / int.Parse(num2));
}
catch (FormatException)
{
    Console.WriteLine("string not allowed");
}
catch (DivideByZeroException)
{
    Console.WriteLine("You can't divide by zero");
}
catch (Exception error)
{
    Console.WriteLine(error);
}
for (int i = 0; i <= 100; i++)
{
    Console.WriteLine(i);
}