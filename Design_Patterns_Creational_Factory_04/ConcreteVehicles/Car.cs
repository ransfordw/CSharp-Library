using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_04.ConcreteVehicles
{
    class Car : IVehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public DoorNumber DoorNumber { get; set; }
        public bool HasGas { get; set; }

        public Car() { }
        public Car(string name, string color, DoorNumber doorNumber, bool hasGas)
        {
            Name = name;
            Color = color;
            DoorNumber = doorNumber;
            HasGas = hasGas;
        }

        public void Brake()
        { 
            Console.WriteLine("Car is braking");
        }

        public void FuelStatus()
        {
            if (HasGas)
                Console.WriteLine("The car has gas in the tank.");
            else
                Console.WriteLine("The tank is empty.");
        }
        
        public void Move()
        {
            Console.WriteLine("Car is driving.");
        }

        public void Start()
        {
            Console.WriteLine("The car starts.");
        }
    }
}
