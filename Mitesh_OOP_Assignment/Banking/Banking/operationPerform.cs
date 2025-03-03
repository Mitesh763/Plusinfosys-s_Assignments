using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Banking
{
    public class operationPerform
    {
        static List<Account> accounts = new List<Account>();
        public static void CreateNewAccount()
        {
            string bankType;
            string ifsc;
            int.TryParse(Console.ReadLine(), out int accType);
            while (true)
            {
                //Console.Write("Select Type of Bank in which will you create account? { 1. HDFC, 2. BOB, 3. SBI, 4. IOB }: ");
                int.TryParse(Console.ReadLine(), out int bankNum);
                void checkBankTypeField()
                {

                if (bankNum == 1)
                {
                    bankType = "HDFC";
                    ifsc = "HDFC123";
                    //break;
                }
                else if (bankNum == 2)
                {
                    bankType = "BOB";
                    ifsc = "BOB123";
                    //break;
                }
                else if (bankNum == 3)
                {
                    bankType = "SBI";
                    ifsc = "SBI123";
                    //break;
                }
                else if (bankNum == 4)
                {
                    bankType = "IOB";
                    ifsc = "IOB123";
                    //break;
                }
                else
                {
                    Console.WriteLine("Invalid Bank Type!");
                }
                }
            }

            string firstName, lastName, userName, email;
            List<string> userField = new List<string>() { "BankType","UserName","FirstName", "LastName","Email","AccountType"};
            Dictionary<int, string> userFilds = new Dictionary<int, string>();

            foreach(string field in userField)
            {
                bool isValid = false;
                while(!isValid)
                {
                    string userInput = Console.ReadLine();
                    if (field.ToLower().Equals("banktypte")) 
                    {
                        Console.Write("Enter Type of Bank in which will you create account ( 1. HDFC, 2. BOB, 3. SBI, 4. IOB ) ? : ");
                    }else if(field.ToLower().Equals("username") || field.ToLower().Equals("firstname") || field.ToLower().Equals("lastname") || field.ToLower().Equals("email"))
                    {
                        Console.WriteLine($"Please enter {field}");
                    }else if (field.ToLower().Equals("accounttype"))
                    {
                        Console.Write("Choose Account Type (1. Savings  2. Current): ");
                    }

                    userInput = Console.ReadLine();
                    if (validateField(field, userInput))
                    {
                        if (field.ToLower().Equals("banktypte"))
                        {
                            userFilds.Add(1, int.TryParse(userInput));
                        }
                        else if (field.ToLower().Equals("username") || field.ToLower().Equals("firstname") || field.ToLower().Equals("lastname") || field.ToLower().Equals("email"))
                        {
                            userFilds.Add(,userInput);
                        }
                        else if (field.ToLower().Equals("accounttype"))
                        {
                            userFilds.Add( , int.TryParse(userInput));
                        }
                    }

                }
            }

            while (true)
            {
                Console.Write("Enter user name: ");
                userName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userName))
                {
                    userFilds.Add(0, userName);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Username!");
                }
            }


            foreach (string field in userField)
            {
                while (true)
                {
                    Console.Write($"Enter {field}: ");
                    string fieldByUser = Console.ReadLine();
                    if (validateField(fieldByUser, field))
                    {
                        userFilds.Add(userField.IndexOf(field)+1, fieldByUser);
                        break;
                    }
                }
            }

            while (true)
            {
                Console.Write("Enter your Email Address: ");
                email = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$"))
                {
                    userFilds.Add(3, email);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Email Address!");
                }
            }

            long accountNumber = new Random().Next(1000, 9999);

            User user = new User { userName = userFilds[0], firstName = userFilds[1], lastName = userFilds[2], email = userFilds[3] };

            Account account; 
            while (true)
            {
                Console.Write("Choose Account Type (1. Savings  2. Current): ");

                if (accType == 1)
                {
                    account = new SavingAccount(bankType, accountNumber, ifsc, user);
                    break;
                }
                else if (accType == 2)
                {
                    account = new CurrentAccount(bankType, accountNumber, ifsc, user);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Account Type!");
                }
            }

            //Console.Write("Do you want Exist from this Operation? (type n or N): ");
            //string continueProcess = Console.ReadLine();
            //if (continueProcess == "n" || continueProcess == "N")
            //{
            //    return;
            //}
            //else
            //{
                accounts.Add(account);
                Console.WriteLine($"Your account has beeen created in {account.bankType}!");
                Console.WriteLine($"Your account number is: {account.accountNumber} and \nYour IFSC code id : {account.ifsc}");
            //}
        }

        public static bool validateField(string fieldCheck, string userInput)
        {
            if (String.IsNullOrEmpty(userInput))
                return false;

            switch (fieldCheck.ToLower())
            {
                case "banktype":chooseBank();
                    break;
                case "firstname":

                    break;
                case "lastname":

                    break;
                case "email":

                    break;
                case "accounttype":

                    break;
                default:
                    break;
            }

            //if (string.IsNullOrWhiteSpace(fieldCheck) || !Regex.IsMatch(fieldCheck, "^[a-zA-Z][a-zA-Z\\s]*$") )
            //{
            //      Console.WriteLine($"Invalid {fieldMessage}!");
            //      return false;
            //}
            //return true;
        }

        static Account getUserAccount(long acNumber)
        {
            return accounts.Find(acc => acc.accountNumber == acNumber);
        }

        public static void depositAmount()
        {
            if (accounts.Count > 0)
            {
                while (true)
                {
                    Console.Write("Enter Account Number: ");
                    long.TryParse(Console.ReadLine(), out long acno);

                    Account ac = operationPerform.getUserAccount(acno);
                    if (ac != null)
                    {
                        Console.Write("Enter deposition Amount: ");
                        double.TryParse(Console.ReadLine(), out double amount);
                        ac.Deposit(amount);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Account Number!");
                        Console.Write("Do you want Exist from this Operation? (type n or N): ");
                        string continueProcess = Console.ReadLine();
                        if (continueProcess == "n" || continueProcess == "N")
                        {
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("There are No account exist!");
            }
        }

        public static void withrawelAmount()
        {

            if (accounts.Count > 0)
            {
                while (true)
                {
                    Console.Write("Enter Account Number: ");
                    long.TryParse(Console.ReadLine(), out long acno);

                    Account ac = operationPerform.getUserAccount(acno);
                    if (ac != null)
                    {
                        Console.Write("Enter Withdrawel Amount: ");
                        double.TryParse(Console.ReadLine(), out double amount);
                        ac.Withdrawel(amount);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Account Number!");
                        Console.Write("Do you want Exist from this Operation? (type n or N): ");
                        string continueProcess = Console.ReadLine();
                        if (continueProcess == "n" || continueProcess == "N")
                        {
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("There are No account exist!");
            }
        }

        public static void transferMoney()
        {

            if (accounts.Count > 1)
            {
                while (true)
                {
                    Console.Write("Enter Your Account number: ");
                    long.TryParse(Console.ReadLine(), out long senderAccNumber);

                    Account senderAccount = operationPerform.getUserAccount(senderAccNumber);
                    if (senderAccount != null)
                    {
                        while (true)
                        {
                            Console.Write("Enter Account number of which you want to send: ");
                            long.TryParse(Console.ReadLine(), out long receiverAccNumber);
                            Account receiverAccount = operationPerform.getUserAccount(receiverAccNumber);
                            if (receiverAccount != null)
                            {
                                Console.Write("Enter Transfer Amount: ");
                                double.TryParse(Console.ReadLine(), out double amount);
                                if (senderAccount.bankType == receiverAccount.bankType)
                                {
                                    senderAccount.transfer(receiverAccount, amount);
                                }
                                else
                                {
                                    Console.Write("Enter IFSC code for transaction in different bank: ");
                                    string receiverIFSC = Console.ReadLine();
                                    senderAccount.transfer(receiverAccount, receiverIFSC, amount);
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Receiver Account Number!");
                                Console.Write("Do you want Exist from this Operation? (type n or N): ");
                                string continueProcess = Console.ReadLine();
                                if (continueProcess == "n" || continueProcess == "N")
                                {
                                    return;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Account Number!");
                        Console.Write("Do you want Exist from this Operation? (type n or N): ");
                        string continueProcess = Console.ReadLine();
                        if (continueProcess == "n" || continueProcess == "N")
                        {
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Minimun 2 account are Required!");
            }
        }

        public static void CheckBalance()
        {

            if (accounts.Count > 0)
            {
                while (true)
                {
                    Console.Write("Enter Account Number: ");
                    long.TryParse(Console.ReadLine(), out long acno);

                    Account ac = operationPerform.getUserAccount(acno);
                    if (ac != null)
                    {
                        ac.fetchBalance();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Account Number!");
                        Console.Write("Do you want Exist from this Operation? (type n or N): ");
                        string continueProcess = Console.ReadLine();
                        if (continueProcess == "n" || continueProcess == "N")
                        {
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("There are No account exist!");
            }
        }
    }
}
