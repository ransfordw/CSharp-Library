using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_04
{
    public class PerformActionTwo : ICommand
    {
        private IReceiver _receiver;

        public PerformActionTwo(IReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.ActionTwo();
        }
    }
}
