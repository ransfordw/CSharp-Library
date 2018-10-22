using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Behavioral_CommandPattern_01
{
    /* The test class or client */
    internal class Program
    {
        public static void Main(string[] arguments)
        {
            string argument = arguments.Length > 0 ? arguments[0].ToUpper() : null;
            argument = "ON";

            ISwitchable lamp = new Light();

            // Pass reference to the lamp instance to each command
            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenSwitchCommand(lamp);

            // Pass reference to instances of the Command objects to the switch
            Switch @switch = new Switch(switchClose, switchOpen);

            if (argument == "ON")
            {
                // Switch (the Invoker) will invoke Execute() on the command object.
                @switch.Open();
            }
            else if (argument == "OFF")
            {
                // Switch (the Invoker) will invoke the Execute() on the command object.
                @switch.Close();
            }
            else
            {
                Console.WriteLine("Argument \"ON\" or \"OFF\" is required.");
            }
            Console.ReadLine();
        }
    }
}
