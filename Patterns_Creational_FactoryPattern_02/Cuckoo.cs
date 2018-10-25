using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_02
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
