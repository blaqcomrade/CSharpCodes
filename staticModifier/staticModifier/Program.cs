namespace staticModifier
{
    class program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car car2 = new car();
            car car3 = new car();    
            car car3 = new car();    
            Console.WriteLine(car.numbers_of_cars);

            car.add();
        }
        
    }
}