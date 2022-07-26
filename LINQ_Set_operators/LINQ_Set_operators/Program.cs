using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Setoperators
{
    internal class Program
    {
        static void Main(string[] mick)
        {
            var datasource = new List<object>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var datasource1 = new List<object>() { 2, 3, 4, 7, 9, 10, 21, 23, 45, };

            var MethodSyntax = datasource.Distinct().ToList();
            var Ms = datasource.Except(datasource1).ToList();
            var ms=datasource.Union(datasource1).ToList();
            var MS = datasource.Intersect(datasource1).ToList();

            Console.ReadLine();
        }
    }
}