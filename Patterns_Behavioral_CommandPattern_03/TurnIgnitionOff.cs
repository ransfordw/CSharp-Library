using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_03
{
    class TurnIgnitionOff : ICommand
    {
        private IIgnitable _ingnitable;

        public TurnIgnitionOff(IIgnitable ignitable)
        {
            _ingnitable = ignitable;
        }

        public void Execute()
        {
            _ingnitable.TurnOff();
        }
    }
}
