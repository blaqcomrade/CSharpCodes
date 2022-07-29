using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompletePhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                            WELCOME TO PHONE BOOK APP");
            PhoneBook contact = new PhoneBook();
            while (true)
            {
               

                string userinput = Console.ReadLine();
                var spilt = userinput.Split();
                var opt = spilt[0];
                

                if (opt == "save")
                {
                    var name = spilt[1];
                    var phonenumber = spilt[2];
                    contact.Add(name, phonenumber);
                }
                else if (opt == "view")
                {
                    var name = spilt[1];
                    contact.View(name);
                }
                else if (opt == "delete")
                {
                    var name = spilt[1];
                    var phonenumber = spilt[2];
                    contact.Delete(name);
                }
                else if (opt == "update")
                {
                    var name = spilt[1];
                    var phonenumber = spilt[2];
                    contact.Update(name , phonenumber);
                }


            }
















        }





}
}

