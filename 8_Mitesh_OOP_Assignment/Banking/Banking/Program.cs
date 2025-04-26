using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text.RegularExpressions;

namespace Banking
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome!");
            while (true)
            {
                Console.WriteLine("\n\nSelect option for operation:");
                Console.WriteLine("1. Create new Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdrawel");
                Console.WriteLine("4. Transfer Money");
                Console.WriteLine("5. Check Balance");
                Console.WriteLine("6. Exit");

                int.TryParse(Console.ReadLine(), out int option);

                switch (option)
                {
                    case 1:
                        operationPerform.CreateNewAccount();
                        break;

                    case 2:
                        operationPerform.depositAmount();
                        break;

                    case 3:
                        operationPerform.withrawelAmount();
                        break;

                    case 4:
                        operationPerform.transferMoney();
                        break;

                    case 5:
                        operationPerform.CheckBalance();
                        break;

                    case 6:
                        Console.WriteLine("Thank You!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Select correct Operation!");
                        break;
                }
            }
        }
    }
}