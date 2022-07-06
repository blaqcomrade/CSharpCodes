// See https://aka.ms/new-console-template for more information
Console.WriteLine(50+25);
string myname = "samuel";
int age = 50;
double height = 2.3;
char initials = 's';
bool male = true;
Console.WriteLine(myname);
Console.WriteLine(age);
Console.WriteLine(height);
Console.WriteLine(initials);
Console.WriteLine(male);
int num1;
num1 = 25;
Console.WriteLine("hi " + myname + " your age is " + age + " your height is " + height + " your initials is " + initials + " you are a male, " + male );
Console.WriteLine($"hello {myname} your age is {age} your height is {height} your initials is {initials} you are a male, {male}");
string num2 = "5";
int num3 = 10;
Console.WriteLine(num2 + num3);
Console.WriteLine(int.Parse (num2) + num3);
Console.Write(num3.ToString() + "5");

Console.WriteLine("enter a first number");
string num4 = Console.ReadLine();
Console.WriteLine("enter a second number");
string num5 = Console.ReadLine();
int answer = (int.Parse(num4) + int.Parse(num5));
Console.WriteLine($"your total answer is {answer} ");


//Console.WriteLine("enter a first number");
//string num4 = Console.ReadLine();
//Console.WriteLine("enter a second number");
//string num5 = Console.ReadLine();
//Console.WriteLine($"your total is {int.Parse(num4) + int.Parse(num5)}");
