using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Creational_FactoryPattern_02
{
    public abstract class Bird
    {
        public  string Sound { get; set; }
        public  string Habitat { get; set; }

        public abstract IAves GetAves(string bird);
    }
}
