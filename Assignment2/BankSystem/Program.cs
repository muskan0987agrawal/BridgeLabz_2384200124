// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace BankSystem
{
    internal class Program
    {
        public static void Main()
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            account.Withdraw(500);
            Console.WriteLine($"Final Balance: {account.Getter()}");
        }
    }
}
