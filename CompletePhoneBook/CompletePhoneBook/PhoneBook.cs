using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompletePhoneBook
{
    internal class PhoneBook
    {
       
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
       

        public void Add(string name, string phonenumber)
        {
            try
            {
                phonebook.Add(name, phonenumber);
                Console.WriteLine("SUCCESSFUL\n");
            }
            catch(Exception)
            {
                Console.WriteLine("NAME ALREADY EXIST");
                Console.WriteLine("FAILED\n");
            }
           
            
        }

        public void View(string name)
        {
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine(phonebook[name] + "\n");
            }
            else
            {
                Console.WriteLine("CONTACT ALREADY EXIST\n");
            }
        }
        
        public void Update(string name, string phonenumber)
        {
            if (phonebook.ContainsKey(name))
            {
                phonebook[name] = phonenumber;
                Console.WriteLine($"Name:{name} successfully updated Number to {phonenumber}\n");
            }
            else
            {
                Console.WriteLine("CONTACT ALREADY EXIST\n");
            }
        }

        public void Delete(string name)
        {
            if (phonebook.ContainsKey(name))
            {
                phonebook.Remove(name);
                Console.WriteLine("CONTACT SUCCESSFULLY DELETED\n");
                
            }
            else
            {
                Console.WriteLine("CONTACT ALREADY EXIST\n");
            }
        }
    }
}
