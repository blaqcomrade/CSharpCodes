using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. oftype and where\n");

            Console.WriteLine("\n---------------------\n");
            Console.WriteLine("2. select and selectmany\n\n");

            List<object> datasource = new List<object>() { "sam", "patrick", "john", 1, 3, 2, 4 };

            var methodsyntax = datasource.OfType<string>().ToList();

            var methodsyntax2 = datasource.OfType<string>().Where(x => x.Length > 5).ToList();


            Console.WriteLine("\n---------------------\n");

            Console.WriteLine("3a");

            foreach (var item in methodsyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n---------------------\n");
            Console.WriteLine("3b");

            foreach (var item in methodsyntax2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n---------------------\n");


            Console.WriteLine("4. SORTING OPERATORS: is used to manage data in a particular order, it may be ascending or descending order.");
            Console.WriteLine("Orderby, Orderbyascending, thenby, thenbyDescending, reverse");

            List<object> datasource1 = new List<object>() { 12, 8, 60, 1, 3, 2, 4 };

            var methodsyntax1 = datasource1.OrderBy(x => x).ToList();

            var methodsyntax3 = datasource1.OrderByDescending(x => x).ToList();


            Console.WriteLine("\n---------------------\n");

            Console.WriteLine("5.\n");
            foreach (var item in methodsyntax1)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n---------------------\n");
            Console.WriteLine("5b\n");

            foreach (var item in methodsyntax3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n---------------------\n");

            Console.WriteLine("6.\n");
            List<test> test1 = new List<test>()
            {
                new test()
                {
                    firstName = "ajeibi",
                    lastName = "samuel"
                },
                 new test()
                {
                    firstName = "john",
                    lastName = "ogbu"
                },
                  new test()
                {
                    firstName = "isaac",
                    lastName = "ugbabe"
                }
            };
        
            var methodsyntax4 = test1.OrderBy(x => x.firstName).ThenBy(x => x.lastName).ToList();

            foreach (var item in methodsyntax4)
            {
                Console.WriteLine($"{item.firstName} {item.lastName}");
            }

            int[] newnumbers = { 1, 2, 3, 4 , 5, 6, 7, 8, 9, 10};

            var Arraymethod = newnumbers.Reverse();


            Console.WriteLine("\n---------------------\n");

            Console.WriteLine("7");
            foreach (var item in Arraymethod)
            {
                Console.WriteLine(item);
            }




        }
    }
}

