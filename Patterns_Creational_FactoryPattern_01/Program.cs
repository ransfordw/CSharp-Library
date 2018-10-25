using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_01
{
    public class Program
    {
        /// <summary>
        /// Demo
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            //Throws Exception
            //IFactory car = factory.GetVehicle("Car");
            //car.Drive(45);

            Console.ReadKey();
        }
    }
}
