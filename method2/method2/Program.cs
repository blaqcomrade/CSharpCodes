// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




//static int rootmethod(int x)
//{
//    return x * x * x ;
//}
//Console.WriteLine(rootmethod(20))



//static void addmethod(string day,double time,int date)
//{
//    Console.WriteLine("Today is " + (day) + " and the time is " + (time) + " and the year is " + (date));
//}
//addmethod("monday",11.23,2002);



//static void addmethod()
//{
//    DateTime now = DateTime.Now;
//    Console.WriteLine("Today is " + (now.ToString("dddd")) + " and the time is " + (now.ToString("hh:mm tt")) + "  the year  " + (now.ToString("yyyy")));
//}
////addmethod();

//static void main(string[] args)
//{
//    Console.Write("first number");
//    int number1 = int.Parse(Console.ReadLine());

//    Console.Write("second number");
//    int number2 = int.Parse(Console.ReadLine());

//    var max = (number1 > number2 ? number1 : number2);
//    Console.WriteLine("Greatest Number: " + max);
//}


static int nemethod(int x, int y)
{
    if (x > y)
    {
        return x;
    }
    else if (y > x)
    {
        return y;
    }
    else
    {
        return 0;
    }

}
Console.WriteLine(nemethod(10, 20));