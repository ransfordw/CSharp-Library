using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_04.ConcreteVehicles
{
    class Boat : IVehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public DoorNumber DoorNumber { get; set; }
        public bool HasGas { get; set; }
        public Boat() { }
        public Boat(string name, string color, DoorNumber doorNumber, bool hasGas)
        {
            Name = name;
            Color = color;
            DoorNumber = doorNumber;
            HasGas = hasGas;
        }

        public void Brake()
        {
            Console.WriteLine("The boat slowly slows down.");
        }

        public void FuelStatus()
        {
            if (HasGas)
                Console.WriteLine("The boat has gas in the tank.");
            else
                Console.WriteLine("The tank is empty. You take out the oars to paddle.");
        }

        public void Move()
        {
            Console.WriteLine("The boat zips across the water.");
        }

        public void Start()
        {
            Console.WriteLine("The boat sputters and starts up.");
        }
    }
}
