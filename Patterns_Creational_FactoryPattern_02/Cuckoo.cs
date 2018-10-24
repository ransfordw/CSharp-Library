using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Creational_FactoryPattern_02
{
    public class Cuckoo : IAves
    {
        public void Call(string sound)
        {
            Console.WriteLine("Cuckoos make a " + sound + " sound.");
        }

        public void WriteHabitat(string habitat)
        {
            throw new NotImplementedException();
        }
    }
}
