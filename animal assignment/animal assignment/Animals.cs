using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_assignment
{
    internal class Animals
    {
        public string Name { get; set; }
        public string Mode_of_feeding { get; set; }

        public string Habitat { get; set; }

        public bool Movement { get; set; }

        public bool Horn { get; set; }


        public string Colony { get; set; }

        public int Legs { get; set; }

        public Animals()
        { }
        public Animals(string name, string feeding, string habita, bool mvt, bool hrn, string cly, int lgs)
        {
            this.Name = name;
            Mode_of_feeding = feeding;
            Habitat = habita;
            Movement = mvt;
            Horn = hrn;
            Colony = cly;
            Legs = lgs;


        }
    }

    
    
}
