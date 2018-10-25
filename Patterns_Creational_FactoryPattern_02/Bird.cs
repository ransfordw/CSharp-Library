using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_02
{
    public abstract class Bird
    {
        public  string Sound { get; set; }
        public  string Habitat { get; set; }

        public abstract IAves GetAves(string bird);
    }
}
