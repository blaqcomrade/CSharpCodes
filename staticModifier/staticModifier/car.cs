using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticModifier
{
    internal class car
    {
        public static int numbers_of_cars;

        public car()
        {
            numbers_of_cars++;
        }

        public static void add()
        {
            Console.WriteLine("The race has started");
        }
    }
}
