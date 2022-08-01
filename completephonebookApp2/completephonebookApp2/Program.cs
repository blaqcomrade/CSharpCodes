using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompletePhoneBookApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            


            TextWriter contact = new StreamWriter(@"C:\Users\Student\Contact.txt", true);

            

            

            Console.WriteLine("please enter operator");
            string opt = Console.ReadLine();
            string userinput = Console.ReadLine();
            var spilt = userinput.Split();
            //var opt = spilt[0];

            var name = spilt[0];
            var phonenumber = spilt[1];



            bool hasName;
            if (opt == "save")
            {
                string[] line = File.ReadAllLines(contact);
);


                if ( line.Contains(name))
                {
                    Console.WriteLine("file already exist");
                }
                else
                {
                    contact.Write($"Name: {name}  PhoneNumber: {phonenumber}\n\n");
                    contact.Close();
                }
           
            }
            //else if (opt == "view")
            //{
            //    var name = spilt[1];
            //    File.View(name);
            //}
            //else if (opt == "delete")
            //{
            //    var name = spilt[1];
            //    var phonenumber = spilt[2];
            //    File.Delete( $"{sw}{Path.GetFileName(name)} ");
            //}
            //else if (opt == "update")
            //{
            //    var name = spilt[1];
            //    var phonenumber = spilt[2];
            //    File.Replace(name, phonenumber);
            //}

        }
    }
}
