using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Behavioral_CommandPattern_04
{
    public class Invoker
    {
        private readonly ICommand _actionOne;
        private readonly ICommand _actionTwo;

        public Invoker(ICommand actionOne, ICommand actionTwo)
        {
            this._actionOne = actionOne;
            this._actionTwo = actionTwo;
        }

        public void ActionOneComplete()
        {
            this._actionOne.Execute();
        }

        public void ActionTwoComplete()
        {
            this._actionTwo.Execute();
        }
    }
}
