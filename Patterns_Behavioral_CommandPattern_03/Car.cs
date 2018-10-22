using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Behavioral_CommandPattern_03
{
    public class Car : IIgnitable
    {
        public void TurnOff()
        {
            Console.WriteLine("The car turns off");
        }

        public void TurnOn()
        {
            Console.WriteLine("The car turns on");
        }
    }
}
