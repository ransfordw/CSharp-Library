using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_03
{
    public interface IIgnitable
    {
        void TurnOn();
        void TurnOff();
    }
}
