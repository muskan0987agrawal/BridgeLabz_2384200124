using System;

namespace BankSystem
{
   public class BankAccount
    {
        private int balance;
        public void Setter(int amount)
        {
            this.balance = amount;
        }

        public int Getter()
        {
            return balance;
        }
        public void Deposit(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            this.balance += amount;
        }

        public void Withdraw(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            this.balance -= amount;
        }
    }
}
