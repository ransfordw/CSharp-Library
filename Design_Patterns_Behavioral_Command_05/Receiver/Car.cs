using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_05.Receiver
{
    public class Car : IVehicle
    {
        public void Brake()
        {
            Console.WriteLine("The car is slowing down");
        }

        public void SpeedUp()
        {
            Console.WriteLine("The car is speeding up.");
        }

        public void TurnOff()
        {
            Console.WriteLine("You turn off the car.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Time for work. Turn on the car.");
        }
    }
}
