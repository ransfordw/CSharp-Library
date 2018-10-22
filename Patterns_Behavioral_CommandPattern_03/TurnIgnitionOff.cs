using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Behavioral_CommandPattern_03
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
