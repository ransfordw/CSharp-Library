using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Behavioral_CommandPattern_04
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
