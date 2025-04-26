using System;

namespace Banking
{
    abstract class Account
    {
        public bool valid = true;
        public string bankType;
        public long accountNumber;
        public string ifsc;
        public double Balance = 10000;
        public User accountHolder;

        public abstract void Deposit(double amount);
        public abstract void Withdrawel(double amount);

        public void transfer(Account receiver, double amount)
        {
            Withdrawel(amount);
            if (valid)
            {
                receiver.Deposit(amount);
            }
        }
        public void transfer(Account receiver, string ifscCode, double amount)
        {
            if (receiver.ifsc == ifscCode)
            {
                Withdrawel(amount);
                if (valid)
                {
                    receiver.Deposit(amount);
                }
            }
            else
            {
                Console.WriteLine("Invalid IFSC!");
            }
        }
        public void fetchBalance()
        {
            Console.WriteLine($"\tTotal Balance: {Balance}");
        }
    }
    class SavingAccount : Account
    {
        public SavingAccount(string bType, long acNumber, string ifscCode, User user)
        {
            bankType = bType;
            accountNumber = acNumber;
            ifsc = ifscCode;
            accountHolder = user;
        }
        public override void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("\tInvalid Amount!");
                valid = false;
                return;
            }
            if (amount + Balance > 49000)
            {
                Console.WriteLine("\tCannot deposit, Beacuse account limit reached!");
                valid = false;
                return;
            }
            Balance += amount;
            valid = true;
            Console.WriteLine($"\tCurrent Balance: {Balance}");
            return;
        }
        public override void Withdrawel(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("\tInvalid Amount!");
                valid = false;
                return;
            }
            if (Balance - amount < 10000)
            {
                Console.WriteLine("\tWithdrawel failed, 10000 minimum Balance required!");
                valid = false;
                return;
            }
            Balance -= amount;
            valid = true;
            Console.WriteLine($"\tCurrent Balance: {Balance}");
        }
    }

    class CurrentAccount : Account
    {

        public CurrentAccount(string bType, long acNumber, string ifscCode, User user)
        {
            bankType = bType;
            accountNumber = acNumber;
            ifsc = ifscCode;
            accountHolder = user;
        }
        public override void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("\tInvalid Amount!");
                valid = false;
                return;
            }
            Balance += amount;
            valid = true;
            Console.WriteLine($"\tCurrent Balance: {Balance}");
            return;
        }
        public override void Withdrawel(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("\tInvalid Amount!");
                valid = false;
                return;
            }
            if (Balance - amount < 0)
            {
                Console.WriteLine("\tYour's Account don't have sufficient Balance!");
                valid = false;
                return;
            }
            Balance -= amount;
            valid = true;
            Console.WriteLine($"\tCurrent Balance: {Balance}");
            return;
        }
    }
}
