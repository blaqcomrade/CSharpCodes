namespace fieldsandpropertiesclasswork
{
    class program
    {
        static void Main(string[] args )
        {
            human man = new human();
            man.eyeproperty = 1;
            man.teethproperty = 40 ;
            man.legproperty = 1;
            man.color = "brown";

            Console.WriteLine(man.eye);
            Console.WriteLine(man.teeth);
            Console.WriteLine(man.leg);
            Console.WriteLine(man.color);
           

        }
    }
}
