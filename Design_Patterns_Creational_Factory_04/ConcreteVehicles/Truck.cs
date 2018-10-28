using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_04.ConcreteVehicles
{
    class Truck : IVehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public DoorNumber DoorNumber { get; set; }
        public bool HasGas { get; set; }

        public Truck() { }
        public Truck(string name, string color, DoorNumber doorNumber, bool hasGas)
        {
            Name = name;
            Color = color;
            DoorNumber = doorNumber;
            HasGas = hasGas;
        }

        public void Brake()
        {
            Console.WriteLine("The truck slows down.");
        }

        public void FuelStatus()
        {
            if (HasGas)
                Console.WriteLine("The truck has gas in the tank.");
            else
                Console.WriteLine("The tank is empty.");
        }

        public void Move()
        {
            Console.WriteLine("The truck drives off the road.");
        }

        public void Start()
        {
            Console.WriteLine("The truck starts up.");
        }
    }
}
