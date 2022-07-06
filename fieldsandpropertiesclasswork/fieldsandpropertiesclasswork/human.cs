using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fieldsandpropertiesclasswork
{
    internal class human
    {
        public int eye;
        public int leg;
        public int teeth;
        public string color{get; set;}


        public int eyeproperty
        {
            get { return eye; }
            set
            {
                if (value > 2 || value < 2)
                {
                    eye = 2;
                }
                else
                {
                    eye = value;
                }
            }
        }
        public int legproperty
        {
            get { return leg; }
            set
            {
                if(value > 2 || value <2)
                {
                    leg = 2;
                }
                else
                {
                    leg = value;
                }
            }
        }
        public int teethproperty
        {
            get { return teeth; }   
            set
            {
                if (value > 32)
                {
                    teeth = 32;
                }
                else
                {
                    teeth = value;
                }

            }
        }
         
    }
}
