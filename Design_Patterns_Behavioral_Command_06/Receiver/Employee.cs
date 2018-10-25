using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_06.Receiver
{
    public class Employee : IAccount
    {
        private decimal _balance;

        public Employee(decimal _balance)
        {
            AccountBalance = _balance;
        }
        public Employee() { }

        public decimal AccountBalance { get; set; }

        public void Deposit(decimal amt)
        {
            Employee employee = new Employee(_balance);

            employee.AccountBalance += amt;
            _balance = employee.AccountBalance;
            Console.WriteLine($"You deposited ${amt} to your account. You now have ${_balance}.");
        }

        public void SeeBalance(decimal amt)
        {
            Employee employee = new Employee(_balance);
            if (_balance == 0)
                _balance = amt;
            employee.AccountBalance = amt;
            Console.WriteLine($"You have ${_balance} in your account.");
        }

        public void Withdraw(decimal amt)
        {
            Employee employee = new Employee(_balance);

            employee.AccountBalance -= amt;
            _balance = employee.AccountBalance;
            Console.WriteLine($"You withdrew ${amt} from your account. You now have ${_balance}.");
        }
    }
}
