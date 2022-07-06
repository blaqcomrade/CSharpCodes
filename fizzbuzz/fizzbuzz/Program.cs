// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for (int i = 1; i <= 100; i++) //we increment i
{
    string output = ""; //we assign a variable output to noting
    if (i % 3 == 0) //finding the modulo of 3 if it has a remainder it wont run
    {
        output = "fizz"; //this code
    }

    if (i % 5 == 0)  //same thing for 5 
    {
        output += "buzz"; //the =+ is thesame if we were to do output = output + "buzz";
    }

    if (output.Length == 0)
    {
        output = i.ToString();
    }
    Console.WriteLine(output);

}