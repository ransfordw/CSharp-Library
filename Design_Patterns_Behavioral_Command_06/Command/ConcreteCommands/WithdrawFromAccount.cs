using Design_Patterns_Behavioral_Command_06.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_06.Command.ConcreteCommands
{
    class WithdrawFromAccount : ICommand
    {
        private IAccount _account;
        public decimal Amount { get; set; }


        public WithdrawFromAccount(IAccount account, decimal amt)
        {
            _account = account;
            Amount = amt;
        }
        public WithdrawFromAccount(IAccount account)
        {
            _account = account;
        }

        public void Execute()
        {
            _account.Withdraw(Amount);
        }
    }
}
