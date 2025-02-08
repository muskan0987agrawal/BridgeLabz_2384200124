/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class BankAccount
    {
        protected string accountNumber;
        protected double balance;

        public BankAccount(string AccountNumber, double Balance)
        {
            this.accountNumber = AccountNumber;
            this.balance = Balance;
        }

  
        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {accountNumber} \nBalance: ${balance} ");
        }
    }

    internal class SavingAccount: BankAccount
    {
        private double interestRate;

        public SavingAccount(string accountNumber, double balance, double interestRate) : base(accountNumber, balance)
        {
            this.interestRate = interestRate;
        }

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Account Type: Savings \nInterest Rate: {interestRate}%");
        }
    }

    internal class CheckingAccount: BankAccount
    {
        private double withdrawalLimit;

        public CheckingAccount(string accountNumber, double balance, double interestRate, double withdrawalLimit) : base(accountNumber, balance)
        {
            this.withdrawalLimit = withdrawalLimit;
        }

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Account Type: Checking \nWithdrawal Limit: ${withdrawalLimit} per day");
        }


    }

    internal class FixedDepositAccount: BankAccount
    {
        private string duration;
        public FixedDepositAccount(string accountNumber, double balance, double interestRate, string duration) : base(accountNumber, balance) {
            this.duration = duration;
        }

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Account Type: Fixed Deposit \nMaturity Period: {duration} months");
        }
    }

    internal class Program8
    {
        public static void Main(string[] args)
        {
            // Creating different bank account types
            SavingAccount savings = new SavingAccount("PUNB1234", 20000,10);
           
            CheckingAccount checking = new CheckingAccount("PUNB4567",7000,20,2000);
           
            FixedDepositAccount fixedDeposit = new FixedDepositAccount("PUNB8907", 9000,22.0,"2");
           
            // Array for polymorphism
            BankAccount[] accounts = { savings, checking, fixedDeposit };

            // While loop for user interaction
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. View Savings Account Details");
                Console.WriteLine("2. View Checking Account Details");
                Console.WriteLine("3. View Fixed Deposit Account Details");
                Console.WriteLine("4. Exit");

                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                if (choice >= 1 && choice <= 3)
                {
                    Console.WriteLine("\nAccount Details:");
                    accounts[choice - 1].DisplayAccountInfo();
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please try again.");
                }
            }
        }
    }

}
*/