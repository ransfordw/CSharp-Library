using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            IIgnitable car = new Car();

            ICommand carOn = new TurnIgnitionOn(car);
            ICommand carOff = new TurnIgnitionOff(car);

            Ignition ignition = new Ignition(carOff, carOn);

            var run = true;
            while (run)
            {
            Console.WriteLine("You have a car. What do you want to do?\n\t1. Turn it on\n\t2. Turn it off");
            var response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        ignition.On();
                        break;
                    case 2:
                        ignition.Off();
                        break;
                    default:
                        Console.WriteLine("Please type 1 or 2");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
