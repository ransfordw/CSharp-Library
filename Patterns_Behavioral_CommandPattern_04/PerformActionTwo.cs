using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Behavioral_CommandPattern_04
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
