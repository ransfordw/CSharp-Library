using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_05.Receiver
{
    public class Motorcycle : IVehicle
    {
        public void Brake()
        {
            Console.WriteLine("You slow your motorbike.");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Someone is on your tail. Speed up!");
        }

        public void TurnOff()
        {
            Console.WriteLine("You've out run them and can rest. Turn off the bike.");
        }

        public void TurnOn()
        {
            Console.WriteLine("The game is afoot! Hop on your bike and go!");
        }
    }
}
