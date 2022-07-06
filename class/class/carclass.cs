using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  carclass
{
    internal class car
    {
        public string Name;  
        public string color;
        public string model;
        public string brand; 

        public car()
        { }

        public car(string name, string color, string model, string brand)
        {
            this.Name = name;
            this.color = color;
            this.model = model;
            this.brand = brand;
        }
    }
}
