using System;

namespace ExceptionHandling
{
    // Custom exception for insufficient funds
    class InsufficientFundsException : Exception
    {
        public double Amount { get; }

        public InsufficientFundsException(string message, double amount) : base(message)
        {
            Amount = amount;
        }
    }

    // Bank Account class
    class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        // Deposit method
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
        }

        // Withdraw method with exception handling
        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount! Withdrawal amount must be positive.");
            }
            if (amount > balance)
            {
                throw new InsufficientFundsException("Insufficient funds for withdrawal.", amount - balance);
            }
            balance -= amount;
            Console.WriteLine($"Withdrawal successful. New balance: ${balance}");
        }

        // Method to get current balance
        public double GetBalance() => balance;
    }

    // Main program to handle exceptions
    internal class BankTransactionHandling
    {
        public static void Main()
        {
            BankAccount account = new BankAccount(100.0);

            try
            {
                Console.Write("Enter deposit amount: ");
                double depositAmount = double.Parse(Console.ReadLine());
                account.Deposit(depositAmount);

                Console.Write("Enter withdrawal amount: ");
                double withdrawAmount = double.Parse(Console.ReadLine());
                account.Withdraw(withdrawAmount);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                Console.WriteLine($"Shortfall: ${e.Amount}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter numeric values.");
            }
            finally
            {
                Console.WriteLine("Transaction completed.");
            }
        }
    }
}
