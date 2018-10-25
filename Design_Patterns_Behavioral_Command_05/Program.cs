using Design_Patterns_Behavioral_Command_05.Command;
using Design_Patterns_Behavioral_Command_05.Command.ConcreteCommands;
using Design_Patterns_Behavioral_Command_05.Invoker;
using Design_Patterns_Behavioral_Command_05.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_05
{
    //Client
    class Program
    {
        static void Main(string[] args)
        {
            //Reciever
            IVehicle car = new Car();
            IVehicle motorcycle = new Motorcycle();

            //Concrete Commands
            ICommand turnOnCommand = new TurnOnVehicle(car);
            ICommand turnOffCommand = new TurnOffVehicle(car);
            ICommand speedUpCommand = new SpeedUpVehicle(car);
            ICommand brakeCommand = new BrakeVehicle(car);

            ICommand turnOnMotorcycle = new TurnOnVehicle(motorcycle);
            ICommand turnOffMotorcycle = new TurnOffVehicle(motorcycle);
            ICommand speedUpMotorcycle = new SpeedUpVehicle(motorcycle);
            ICommand brakeMotorcycle = new BrakeVehicle(motorcycle);

            //Invoker
            VehicleInvoker invoker = new VehicleInvoker(turnOnCommand, turnOffCommand, brakeCommand, speedUpCommand);
            VehicleInvoker motorcycleInvoker = new VehicleInvoker(turnOnMotorcycle, turnOffMotorcycle, brakeMotorcycle, speedUpMotorcycle);

            invoker.TurnOn();
            invoker.SpeedUp();
            invoker.Brake();
            invoker.TurnOff();

            Console.WriteLine();

            motorcycleInvoker.TurnOn();
            motorcycleInvoker.SpeedUp();
            motorcycleInvoker.Brake();
            motorcycleInvoker.TurnOff();

            Console.ReadLine();
        }
    }
}
