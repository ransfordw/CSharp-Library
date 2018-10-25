using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_06.Command
{
    public interface ICommand
    {
        decimal Amount { get; set; }

        void Execute();
    }
}
