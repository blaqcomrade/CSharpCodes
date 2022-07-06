namespace carclass
{
    class program
    {

        static void main(string[] args)
        {
            car car1 = new car();
            car1.Name = "Toyota camry";
            car1.color = "Red";
            car1.model = "camry 2018 model";
            car1.brand = "cr5";
            Console.WriteLine(car1.Name);

            car car2 = new car();
            car2.Name = "Mercedes Benz";
            car2.color = "black";
            car2.model = "2019 model";
            car2.brand = "ML 360";
            Console.WriteLine(car2.Name);

            car car3 = new car(" Honda","white","2014 model","C class");
            Console.WriteLine(car3.Name);
           
        }

    }

}
