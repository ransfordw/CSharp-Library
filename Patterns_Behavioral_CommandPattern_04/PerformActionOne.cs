using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_04
{
    public class PerformActionOne : ICommand
    {
        private IReceiver _receiver;

        public PerformActionOne(IReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.ActionOne();
        }
    }
}
