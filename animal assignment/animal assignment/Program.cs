namespace animal_assignment
{
    class program
    {
        static void Main(string[] args)
        {
            //    Anim  als animal1 = new Animals();
            //    animal1.Name = "lion";
            //    animal1.Mode_of_feeding = "lions are carnivorious";
            //    animal1.Habitat = "Terrestia (animals that live on land)";
            //    animal1.Movement = true ;
            //    animal1.Horn = false ;
            //    animal1.Colony = "pride";
            //    animal1.Legs = 2;

            //    Animals animal2 = new Animals();
            //    animal2.Name = "goat";
            //    animal2.Mode_of_feeding = "Goat are herbivorios";
            //    animal2.Habitat = "Terrestia (animals that live on land";
            //    animal2.Movement = true ;
            //    animal2.Horn = false;
            //    animal2.Colony = "tribe";
            //    animal2.Legs = 2;

            //    Animals animal3 = new Animals();
            //    animal3.Name = "leopard";
            //    animal3.Mode_of_feeding = "leopard are ominivorios";
            //    animal3.Habitat = "Terrestia (animals that live on land";
            //    animal3.Movement = true;
            //    animal3.Horn = false;
            //    animal3.Colony = "leap";
            //    animal3.Legs = 2;

            //    Animals animal4 = new Animals();
            //    animal4.Name = "apes";
            //    animal4.Mode_of_feeding = "apes are ominivorios";
            //    animal4.Habitat = "Terrestia (animals that live on land";
            //    animal4.Movement = true;
            //    animal4.Horn = false;
            //    animal4.Colony = "paliaments";
            //    animal4.Legs = 2;

            //    Animals animal5 = new Animals();
            //    animal5.Name = "Tiger";
            //    animal5.Mode_of_feeding = "Tiger are carnivorious";
            //    animal5.Habitat = "Terrestia (animals that live on land)";
            //    animal5.Movement = true;
            //    animal5.Horn = false ;
            //    animal5.Colony = "armbush";
            //    animal5.Legs = 2;

            //    Animals animal6 = new Animals("rat", "ominivorios", "terrestia", true, false, "mischief", 2) ;
            //    Console.WriteLine(animal6.Name);

            //    List<object> total = new List<object>();
            //    total.Add(animal1.Name);
            //    total.Add(animal1.Mode_of_feeding);
            //    total.Add(animal1.Habitat);
            //    total.Add(animal1.Movement);
            //    total.Add(animal1.Horn);
            //    total.Add(animal1.Colony);
            //    total.Add(animal1.Legs);
            //    total.Add(animal2.Name);
            //    total.Add(animal2.Mode_of_feeding);
            //    total.Add(animal2.Habitat);
            //    total.Add(animal2.Movement);
            //    total.Add(animal2.Horn);
            //    total.Add(animal2.Colony);
            //    total.Add(animal2.Legs);
            //    total.Add(animal3.Name);
            //    total.Add(animal3.Mode_of_feeding);
            //    total.Add(animal3.Habitat);
            //    total.Add(animal3.Movement);
            //    total.Add(animal3.Horn);
            //    total.Add(animal3.Colony);
            //    total.Add(animal3.Legs);
            //    total.Add(animal5.Name);
            //    total.Add(animal5.Mode_of_feeding);
            //    total.Add(animal5.Habitat);
            //    total.Add(animal5.Movement);
            //    total.Add(animal5.Horn);
            //    total.Add(animal5.Colony);
            //    total.Add(animal5.Legs);
            //    total.Add(animal6.Name);
            //    total.Add(animal6.Mode_of_feeding);
            //    total.Add(animal6.Habitat);
            //    total.Add(animal6.Movement);
            //    total.Add(animal6.Horn);
            //    total.Add(animal6.Colony);
            //    total.Add(animal6.Legs);





            //    foreach (object name in total)
            //    {
            //        Console.WriteLine(name);
            //    }

            List<Animals> listquestions = new List<Animals>()
            {
                new Animals("lion","carnivorios","Terrestia",true,false,"pride",2),
                new Animals("Goat","herbivorios","Terrestia",true,false,"tribe",2),
                new Animals("Leopard","carnivorios","Terrrestia",true,false,"leap",2)
            };
            for(int i = 0; i < listquestions.Count; i++)
            {
                Console.WriteLine(listquestions[i].Name);
            }
        }
    }
    
}