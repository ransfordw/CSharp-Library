using Design_Patterns_Behavioral_Command_06.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_06.Invoker
{
    class AccountInvoker
    {
        private ICommand _seeBalance, _withdraw, _deposit;

        public AccountInvoker(ICommand seeBalance, ICommand withdraw, ICommand deposit)
        {
            _seeBalance = seeBalance;
            _withdraw = withdraw;
            _deposit = deposit;
        }

        //Invoker Methods
        public void SeeBalance()
        {
            _seeBalance.Execute();
        }

        public void Withdraw(decimal _amt)
        {
            _withdraw.Amount = _amt;
            _withdraw.Execute();
        }

        public void Deposit(decimal _amt)
        {
            _deposit.Amount = _amt;
            _deposit.Execute();
        }
    }
}
