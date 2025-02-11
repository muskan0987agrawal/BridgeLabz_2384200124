using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        // Encapsulation with Properties
        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) holderName = value;
                else Console.WriteLine("Invalid Account Number!");
            }
        }

        public string HolderName
        {
            get { return holderName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) holderName = value;
                else Console.WriteLine("Holder Name cannot be empty!");
            }
        }

        public double Balance
        {
            get { return balance; }
            protected set // Balance update restricted
            {
                if (value >= 0) balance = value;
                else Console.WriteLine("Balance cannot be negative!");
            }
        }

        // Deposit Method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
            }
            else
                Console.WriteLine("Deposit amount must be positive!");
        }
        //Withdraw Method
        public  void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}, Remaining Balance: {Balance}");
            }
            else
                Console.WriteLine("Invalid Withdraw Amount!");
        }

        //Abstract method for interest calculation
        public abstract double CalculateInterest();

        // Display account details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Account No: {AccountNumber}, Name: {HolderName}, Balance: {Balance}");
        }

    }
}
