using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_04
{
    abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string userInput, string name, string color, DoorNumber doorNumber, bool hasGas);
    }
}
