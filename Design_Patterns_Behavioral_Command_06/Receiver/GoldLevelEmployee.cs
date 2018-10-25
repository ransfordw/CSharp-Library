using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_06.Receiver
{
    public class GoldLevelEmployee : IAccount
    {
        private decimal _balance;
        public GoldLevelEmployee(decimal balance)
        {
            AccountBalance = balance;
        }
        public GoldLevelEmployee() { }

        public decimal AccountBalance { get; set; }

        public void Deposit(decimal amt)
        {
            Employee employee = new Employee(_balance);
            employee.AccountBalance += amt;
            _balance = employee.AccountBalance;

            Console.WriteLine($"Beloved asset, you have made a contribution of ${amt} to your future. May you never step on a lego.");
        }

        public void SeeBalance(decimal amt)
        {
            Employee employee = new Employee(_balance);
            if (_balance == 0)
                _balance = amt;
            employee.AccountBalance = amt;
            Console.WriteLine($"Esteemed patron, you have ${_balance} in your account. I hope this news brings you peace.");
        }

        public void Withdraw(decimal amt)
        {
            Employee employee = new Employee(_balance);
            employee.AccountBalance -= amt;
            _balance = employee.AccountBalance;
            Console.WriteLine($"Kind soul, you have withdrawn ${amt} from your funds. Spend it wisely.");
        }
    }
}
