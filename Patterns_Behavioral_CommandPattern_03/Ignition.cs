using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_03
{
    public class Ignition
    {
        ICommand _turnOnCommand;
        ICommand _turnOffCommand;

        public Ignition(ICommand turnedOffCommand, ICommand turnedOnCommand)
        {
            this._turnOffCommand = turnedOffCommand;
            this._turnOnCommand = turnedOnCommand;
        }

        public void On()
        {
            this._turnOnCommand.Execute();
        }

        public void Off()
        {
            this._turnOffCommand.Execute();
        }
    }
}
