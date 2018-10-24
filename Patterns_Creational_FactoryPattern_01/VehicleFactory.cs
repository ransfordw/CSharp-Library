using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Creational_FactoryPattern_01
{
    /// <summary>
    /// Abstract Creator class
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string vehicle);
    }
}
