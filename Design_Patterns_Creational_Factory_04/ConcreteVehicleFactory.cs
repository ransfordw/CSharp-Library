using Design_Patterns_Creational_Factory_04.ConcreteVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_04
{
    class ConcreteVehicleFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string userInput, string name, string color, DoorNumber doorNumber, bool hasGas)
        {
            switch (userInput)
            {
                case "1":
                    return new Car(name, color, doorNumber, hasGas);
                case "2":
                    return new Boat(name, color, doorNumber, hasGas);
                case "3":
                    return new Truck(name, color, doorNumber, hasGas);
                default:
                    throw new ApplicationException("No valid input recieved.");
            }
        }
    }
}
