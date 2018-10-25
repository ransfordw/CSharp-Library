using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_04
{
    public class Receiver : IReceiver
    {
        public void ActionOne()
        {
            Console.WriteLine("Action one is performed.");
        }

        public void ActionTwo()
        {
            Console.WriteLine("Action two is performed.");
        }
    }
}
