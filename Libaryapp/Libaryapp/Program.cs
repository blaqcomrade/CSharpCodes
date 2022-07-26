Console.WriteLine("                                 WELCOME TO THE LIBARY\n\n");



Console.WriteLine("                     Enter [1] to borrow book or [2] to return book\n\n");
static void method()
{
    int choose;
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

static void borrowbook();
{
    List<object> Books = new List<object>();
    Books.Add("asdf");
    Books.Add("asdf");
    Books.Add("asdf");
    Books.Add("asdf");
    Books.Add("asdf");
    Books.Add("asdf");

    foreach (var item in Books)
    {
        Console.WriteLine(Books);
    }
    Console.WriteLine("choose a book to borrow");
    string op = Console.ReadLine();

    if (Books.Contains(op))
    {
        Books.Remove(op);
        Console.WriteLine("You have successfully borrowed " + op);
    }
    foreach (var item in Books)
    {
        Console.WriteLine(Books);
        method();
    }
}

static void returnbook();
{
    Console.WriteLine("adf");
}
