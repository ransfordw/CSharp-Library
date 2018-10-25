using Design_Patterns_Behavioral_Command_05.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_05.Command.ConcreteCommands
{
    class BrakeVehicle : ICommand
    {
        private IVehicle _vehicle;

        public BrakeVehicle(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Execute()
        {
            _vehicle.Brake();
        }
    }
}
