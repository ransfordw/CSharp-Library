using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_04
{
    public class Invoker
    {
        private readonly ICommand _actionOne;
        private readonly ICommand _actionTwo;

        public Invoker(ICommand actionOne, ICommand actionTwo)
        {
            _actionOne = actionOne;
            _actionTwo = actionTwo;
        }

        public void ActionOneComplete()
        {
            _actionOne.Execute();
        }

        public void ActionTwoComplete()
        {
            _actionTwo.Execute();
        }
    }
}
