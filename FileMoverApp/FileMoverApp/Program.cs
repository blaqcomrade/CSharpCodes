using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileMoverApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\Student\Downloads";


            var files = Directory.GetFiles(rootpath, "*.JPG", SearchOption.AllDirectories);


            string newpath = @"C:\Users\Student\Downloads\imgsubfolder\";

            if (Directory.Exists(newpath))
            {
                Console.WriteLine("The directory already exist");
            }
            else
            {
                Directory.CreateDirectory(newpath);
            }

            foreach (string file in files)
            {



                try
                {
                    
                    if (File.Exists(file))
                    {
                        
                        throw new ArgumentException("file already exist");
                       
                    }
                    else
                    {
                        File.Move(file, $"{newpath}{Path.GetFileName(file)} ");
                    }
                }
                catch(Exception)
                {

                    //System.Exception("")
                    
                }



                int choose;

                Console.WriteLine("enter 1 to replace 2 to quite");
                try
                {
                    choose = Convert.ToInt32(Console.ReadLine());
                    string opt = Console.ReadLine();

                    switch (choose)
                    {
                        case 1:

                            File.Replace(rootpath, newpath, newpath);

                            break;

                        case 2:


                            Environment.Exit(0);

                            break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("string not allowed");
                }




               
                Console.ReadLine();


            }




        }
        }
    }

