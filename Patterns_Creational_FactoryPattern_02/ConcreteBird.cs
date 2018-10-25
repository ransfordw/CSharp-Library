using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_02
{
    public class ConcreteBird : Bird
    {
        public override IAves GetAves(string bird)
        {
            switch (bird)
            {
                case "Chickadee":
                    return new Chickadee();
                case "Crow":
                    return new Crow();
                case "Cuckoo":
                    return new Cuckoo();
                default:
                    throw new ApplicationException("Bird could not be identified");
            }
        }
    }
}
