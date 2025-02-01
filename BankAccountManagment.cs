/*using System;

class BankAccount
{
    public int accountNumber;  // Public - Accessible everywhere
    protected string accountHolder;  // Protected - Accessible in derived class
    private double balance;  // Private - Only accessible within BankAccount

    public BankAccount(int accNumber, string holder, double initialBalance)
    {
        accountNumber = accNumber;
        accountHolder = holder;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
    }

    public double GetBalance() // Public method to access balance
    {
        return balance;
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(int accNumber, string holder, double initialBalance)
        : base(accNumber, holder, initialBalance) {}

    public void ShowAccountDetails()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Balance: ₹{GetBalance()}");
    }
}

class BankAccountManagment
{
    static void Main()
    {
        SavingsAccount acc = new SavingsAccount(101, "Muskan", 500000);
        acc.ShowAccountDetails();
		Console.WriteLine("After withdraw Money: ");
		acc.Withdraw(100000);
		acc.ShowAccountDetails();
    }
}
*/