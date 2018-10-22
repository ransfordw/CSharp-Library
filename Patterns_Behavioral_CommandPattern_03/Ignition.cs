using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Behavioral_CommandPattern_03
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
