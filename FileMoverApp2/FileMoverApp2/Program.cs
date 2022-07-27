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


            var files = Directory.GetFiles(rootpath, "*.JPG");
            

            string newpath = @"C:\Users\Student\Downloads\imgsubfolder";

           if (files.Length == 0)
            {
                Console.WriteLine("sorry image file does not exist");
            }
           
            foreach (string file in files)
            {
                if (Directory.Exists(newpath))
                {

                    try
                    {
                        File.Move(file, $"{newpath}{Path.GetFileName(file)} ");
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("sorry file already exist");
                    }

                   
                }
                else
                {
                    Directory.CreateDirectory(newpath);
                    File.Move(file, $"{newpath}{Path.GetFileName(file)} ");
                    Console.WriteLine("IMAGES MOVED SUCCESSFULLY");
                }

                break;
            }
           
            Console.ReadLine();
        }

    }
}

