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
    public class ProgramUI
    {
        private IAccount _newAccount;
        private ICommand _seeBalance, _withdraw, _deposit;
        private AccountInvoker _invoker;
        private decimal _clientBalance;

        public void Run()
        {
            Console.WriteLine("Please enter your name:");
            var clientName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"{clientName}, What is your initial deposit?");
            _clientBalance = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Are you a Gold member? y/n");
            var memberResponse = Console.ReadLine();

            if (memberResponse == "y" || memberResponse == "Y")
                _newAccount = new GoldLevelEmployee();
            else
                _newAccount = new Employee();

            _seeBalance = new SeeAccountBalance(_newAccount, _clientBalance);
            _withdraw = new WithdrawFromAccount(_newAccount, _clientBalance);
            _deposit = new DepositToAccount(_newAccount, _clientBalance);
            _invoker = new AccountInvoker(_seeBalance, _withdraw, _deposit);

            Console.WriteLine($"Welcome {clientName} To Account Manager!" +
                $"\n\nPress any key to continue...");
            Console.ReadKey();
            var response = true;
            while (response)
            {
                Console.WriteLine($"\nWhat would you like to do?\n\t" +
                    "1. See funds.\n\t" +
                    "2. Deposit funds.\n\t" +
                    "3. Withdraw funds.\n\t" +
                    "4. See Account History\n\t" +
                    "5. Revert action\n\t" +
                    "6. Exit.");
                var menuResponse = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (menuResponse)
                {
                    case 1:
                        _invoker.SeeBalance();
                        break;
                    case 2:
                        decimal deposit = 0m;
                        Console.WriteLine("How much will you be depositing?");
                        deposit = decimal.Parse(Console.ReadLine());
                        _invoker.Deposit(deposit);
                        break;
                    case 3:
                        UIWithdraw();
                        break;
                    case 4:
                        Console.WriteLine("We apologize. This feature is not yet available.");
                        break;
                    case 5:
                        Console.WriteLine("We apologize. This feature is not yet available.");
                        break;
                    case 6:
                        response = false;
                        break;
                }
            }
        }

        private void UIWithdraw()
        {
            Console.Write("How much will you be withdrawing?\n$");
            decimal withdrawl = decimal.Parse(Console.ReadLine());
            _invoker.Withdraw(withdrawl);
        }
    }
}
