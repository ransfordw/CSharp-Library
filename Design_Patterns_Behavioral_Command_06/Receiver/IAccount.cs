using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_06.Receiver
{
    public interface IAccount
    {
        decimal AccountBalance { get; set; }

        void SeeBalance(decimal amt);
        void Withdraw(decimal amt);
        void Deposit(decimal amt);
    }
}
