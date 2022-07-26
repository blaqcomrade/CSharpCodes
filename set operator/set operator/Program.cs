using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Set_operator
{
    internal class Program
    {
        static void Main(string[] mick)
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {Id=1,StudentName="Isama Michael", Average=98.70,
                subjects=new List<Subject>()
                {
                    new Subject(){SubjectName="English Language", Score=99},
                    new Subject(){SubjectName="Biology", Score=97},
                    new Subject(){SubjectName="Physics", Score=95},
                    new Subject(){SubjectName="Chemistry", Score=100}
                }
                },
                new Student()
                {Id=1,StudentName="Basil Precious", Average=95.45,
                subjects=new List<Subject>()
                {
                    new Subject(){SubjectName="English Language", Score=95},
                    new Subject(){SubjectName="Biology", Score=94},
                    new Subject(){SubjectName="Physics", Score=91},
                    new Subject(){SubjectName="Chemistry", Score=90}
                }
                },
                new Student()
                {Id=1,StudentName="Onoja Augustine", Average=92.56,
                subjects=new List<Subject>()
                {
                    new Subject(){SubjectName="English Language", Score=93},
                    new Subject(){SubjectName="Biology", Score=87},
                    new Subject(){SubjectName="Physics", Score=88},
                    new Subject(){SubjectName="Chemistry", Score=82}
                }
                },
                new Student()
                {Id=1,StudentName="Matthew Blessing", Average=87.6,
                subjects=new List<Subject>()
                {
                    new Subject(){SubjectName="English Language", Score=79},
                    new Subject(){SubjectName="Biology", Score=80},
                    new Subject(){SubjectName="Physics", Score=90},
                    new Subject(){SubjectName="Chemistry", Score=77}
                }
                }
            };


        // ALL  METHOD ========================================================================================================================
        // ====================================================================================================================================


            var ms = students.Where(x => x.subjects.All(x => x.Score > 90)).Select(x=>x.StudentName).ToList();


        // ANY METHOD =========================================================================================================================
        // ====================================================================================================================================


            var Ms = students.Where(x => x.subjects.Any(x => x.Score > 90)).Select(x => x.StudentName).ToList();




            List<Employee> employees = new List<Employee>()
           {
               new Employee(){Id=1, Name="Agbochenu Favour"},
               new Employee(){Id=2, Name="Ochigbo Martha"}
           };

            var comparer = new EmployeeComparer();

            

            var isExist = employees.Contains(new Employee() { Id = 1, Name = "Agbochenu Favour" }, comparer);


            // OR ============================================================================================================================
            //================================================================================================================================


            var std = new Employee() { Id = 1, Name = "Agbochenu Favour" };

            employees.Add(std);

            var exist = employees.Contains(std);



            Console.ReadLine();
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public double Average { get; set; }
        public List<Subject> subjects { get; set; }
    }

    class Subject
    {
        public string SubjectName { get; set; }
        public int Score { get; set; }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class EmployeeComparer : IEqualityComparer<Employee>
    {
       public bool Equals(Employee x, Employee y)
        {
            if(object.ReferenceEquals(x, y))
            {
                return true;
            }
            if(object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }
            return x.Id==y.Id && x.Name==y.Name;
        }

        public int GetHashCode(Employee obj)
        {
            if(object.ReferenceEquals(obj, null))
            {
                return 0;
            }
            int idHashcode = obj.Id.GetHashCode();
            int nameHashcode = obj.Name == null ? 0 : obj.Name.GetHashCode();
            return idHashcode ^ nameHashcode;
        }
    }
}