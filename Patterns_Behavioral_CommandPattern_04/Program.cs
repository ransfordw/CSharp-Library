using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_04
{
    class Program
    {
        static void Main(string[] args)
        {
            IReceiver receiver = new Receiver();

            ICommand receiverFirst = new PerformActionOne(receiver);
            ICommand receiverSecond = new PerformActionTwo(receiver);

            Invoker invoker = new Invoker(receiverFirst, receiverSecond);

            var run = true;
            while (run)
            {
                Console.WriteLine("You have a receiver. What do you want to do?\n\t1. Perform First Action\n\t2. Perform Second Action");
                var response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        invoker.ActionOneComplete();
                        break;
                    case 2:
                        invoker.ActionTwoComplete();
                        break;
                    default:
                        Console.WriteLine("Please type 1 or 2");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
