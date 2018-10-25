using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_01
{
    /// <summary>
    /// A ConcreteProduct class
    /// </summary>
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Ride the Bike: " + miles.ToString() + " miles");
        }
    }
}
