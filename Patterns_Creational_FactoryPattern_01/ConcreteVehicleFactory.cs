using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Creational_FactoryPattern_01
{
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string vehicle)
        {
            switch (vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", vehicle));
            }
        }
    }
}
