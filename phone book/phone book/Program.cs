

Dictionary<string, string> phonebook = new Dictionary<string, string>();
while (true)
{
    Console.WriteLine("what would u like to do SAVE,VIEW,DELETE,UPDATE");
    string op = Console.ReadLine();

    if (op == "SAVE")
    {
        Console.WriteLine("Enter contact name");
        string name = Console.ReadLine();
        Console.WriteLine("enter contact number");
        string number = Console.ReadLine();
        phonebook.Add(name, number);
        Console.WriteLine("" + name + " sucessfully saved");
    }


    else if (op == "VIEW")
    {
        Console.WriteLine("enter contact name to view");
        string contactname = Console.ReadLine();
        if (phonebook.ContainsKey(contactname))
        {
            Console.WriteLine(phonebook[contactname]);
        }
        else
        {
            Console.WriteLine("contact does not exist");
        }

    }


    else if (op == "UPDATE")
    {
        Console.WriteLine("enter contact name to update");
        string name = Console.ReadLine();
        Console.WriteLine("enter new number  to update");
        string number = Console.ReadLine();
        phonebook[name] = number;
        Console.WriteLine(phonebook[name]);
        Console.WriteLine("number updated sucessfully");
    }


    else if (op == "DELETE")
    {
        Console.WriteLine("enter contact name to delete");
        string name = Console.ReadLine();
        if (phonebook.ContainsKey(name))
        {
            phonebook.Remove(name);
            Console.WriteLine("number deleted sucessfully");

        }
        else
        {
            Console.WriteLine("number does not exist");
        }
    }

    else
    {
        Console.WriteLine("invalid command");
    }
}
