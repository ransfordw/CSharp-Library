using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_01
{
    /// <summary>
    /// Abstract Creator class
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string vehicle);
    }
}
