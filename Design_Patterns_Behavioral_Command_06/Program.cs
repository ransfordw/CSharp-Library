using Design_Patterns_Behavioral_Command_06.Command;
using Design_Patterns_Behavioral_Command_06.Command.ConcreteCommands;
using Design_Patterns_Behavioral_Command_06.Invoker;
using Design_Patterns_Behavioral_Command_06.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_06
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI program = new ProgramUI();
            program.Run();
        }
    }
}
