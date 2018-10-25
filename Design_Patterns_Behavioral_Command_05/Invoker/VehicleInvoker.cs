using Design_Patterns_Behavioral_Command_05.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_05.Invoker
{
    class VehicleInvoker
    {
        private ICommand _turnOn, _turnOff, _speedUp, _brake;

        public VehicleInvoker(ICommand turnOn, ICommand turnOff, ICommand brake, ICommand speedUp)
        {
            _turnOn = turnOn;
            _turnOff = turnOff;
            _brake = brake;
            _speedUp = speedUp;
        }

        //Invoker Methods
        public void TurnOn()
        {
            _turnOn.Execute();
        }

        public void TurnOff()
        {
            _turnOff.Execute();
        }

        public void SpeedUp()
        {
            _speedUp.Execute();
        }

        public void Brake()
        {
            _brake.Execute();
        }

    }
}
