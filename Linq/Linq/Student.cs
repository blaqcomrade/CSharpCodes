using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Student
    {
        public string first_name { get; set; }
        public string surname { get; set; }
        public string current_class { get; set; }
        public double result_average { get; set; }



        public Student()
        { }

        public Student(string first, string sur_name, string current_clas, double result_avg)
        {
           first_name = first;
           surname = sur_name;
           current_class = current_clas;
           result_average = result_avg;
        }
        
    }
}
