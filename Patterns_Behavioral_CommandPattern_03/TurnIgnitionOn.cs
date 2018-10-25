using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_03
{
    public class TurnIgnitionOn : ICommand
    {
        private IIgnitable _ingnitable;

        public TurnIgnitionOn(IIgnitable ignitable)
        {
            _ingnitable = ignitable;
        }

        public void Execute()
        {
            _ingnitable.TurnOn();
        }
    }
}
