using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Behavioral_CommandPattern_04
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
