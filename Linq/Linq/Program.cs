using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Linq
{
    class program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("patrick","ogbo","jss3",48.6),
                new Student("john","eje","ss3",70.0),
                new Student("isaac","ugbabe","jss1",-41.6),
                new Student("vincent","otopka","jss1",80.0),
                new Student("peter","ada","ss3",99.9),
                new Student("lech","philip","jss2",80.0),
                new Student("edward","ode","ss3",99.9),
            };

            //var querysyntax = from obj in students
            //                  where obj.current_class == "jss1"
            //                  select obj;

            var methodsyntax = students.Where(obj => obj.current_class == "jss1" && obj.result_average >= 50);
           

            var mixedsyntax = (from obj in students
                               select obj.result_average).Max();

            //Console.WriteLine("Max value =" + mixedsyntax);

            foreach (var student in methodsyntax)
            {
                Console.WriteLine($"Name:{student.first_name}, surname:{student.surname}, current class:{student.current_class}, Average:{student.result_average}\n");
            }

        }
    }
}