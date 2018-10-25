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
            decimal balance = 300.00m;
            decimal kennBalance = 3500.45m;
            //Reciever
            IAccount paul = new Employee();
            IAccount kenn = new GoldLevelEmployee();
            
            //Concrete Commands
            ICommand seeBalance = new SeeAccountBalance(paul, balance);
            ICommand withdraw = new WithdrawFromAccount(paul, balance);
            ICommand deposit = new DepositToAccount(paul, balance);

            ICommand kennSeeBalance = new SeeAccountBalance(kenn, kennBalance);
            ICommand kennWithdraw = new WithdrawFromAccount(kenn, kennBalance);
            ICommand kennDeposit = new DepositToAccount(kenn, kennBalance);

            //Invoker
            AccountInvoker invoker = new AccountInvoker(seeBalance, withdraw, deposit);
            AccountInvoker kennInvoker = new AccountInvoker(kennSeeBalance, kennWithdraw, kennDeposit);

            invoker.SeeBalance();
            invoker.Withdraw(50.00m);
            invoker.Deposit(125.00m);
            invoker.SeeBalance();

            Console.WriteLine();

            kennInvoker.SeeBalance();
            kennInvoker.Deposit(545m);
            kennInvoker.Withdraw(1200.43m);
            kennInvoker.SeeBalance();

            Console.ReadLine();
        }
    }
}
