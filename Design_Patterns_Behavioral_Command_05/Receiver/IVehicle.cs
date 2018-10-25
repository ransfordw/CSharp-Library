using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_05.Receiver
{
    public interface IVehicle
    {
        void TurnOn();
        void TurnOff();
        void Brake();
        void SpeedUp();
    }
}
