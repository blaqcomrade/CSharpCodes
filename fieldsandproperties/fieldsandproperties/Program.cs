
namespace fieldsandproperties
{

    class program
    {
        static void Main(string[] args)
        {
            Car carproperty = new Car();
            carproperty.speedproperty = 5000;
            carproperty.wheelproperty = 5;
            carproperty.color = "Red";

            Console.WriteLine(carproperty.speedproperty);
            Console.WriteLine(carproperty.wheelproperty);
        }
    }

}