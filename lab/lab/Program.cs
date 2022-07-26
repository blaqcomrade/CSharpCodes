
Console.WriteLine("                                 WELCOME TO THE LIBARY\n\n");

method();
static void method()
{
    int choose;
    Console.WriteLine("                                 What will you like to do\n");


    Console.WriteLine("               Enter [1] to borrow book or [2] to return book or [3] to exit the libary\n");



    try
    {
        choose = Convert.ToInt32(Console.ReadLine());

        switch (choose)
        {
            case 1:

                borrowbook();

                break;

            case 2:

                returnbook();
                break;

            case 3:

                Environment.Exit(0);
                break;

            default:

                Console.WriteLine("invalid entry");

                break;
        }
    }
    catch
    {
        Console.WriteLine("string not allowed");

    }

}
static void borrowbook()
{
    List<string> Books = new List<string>();
    Console.WriteLine("LIST OF AVAILABLE BOOKS");
    Books.Add("go home");
    Books.Add("crime");
    Books.Add("love");
    Books.Add("cultism");
    Books.Add("john");
    Books.Add("patrick");


    foreach (var item in Books)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("choose a book to borrow");
    string op = Console.ReadLine();

    if (Books.Contains(op))
    {
        Books.Remove(op);
        Console.WriteLine("You have successfully borrowed " + op);
    }
    else
    {
        Console.WriteLine($"sorry  {op} not available ");
    }
    foreach (var item in Books)
    {
       
      
        Console.WriteLine(item);

    }
}

static void returnbook()
{
    Console.WriteLine("adf");
}
