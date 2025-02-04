//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using System;
//using System.Security.Principal;

//class BankAccount
//{
//    // Static variable shared across all accounts
//    private static string bankName = "State Bank Of India";
//    private static int totalAccounts = 0;

//    // Readonly variable to ensure AccountNumber cannot be changed
//    private readonly int AccountNumber;
//    private string AccountHolderName;
//    private double Balance;

//    // Constructor using 'this' keyword to resolve ambiguity
//    public BankAccount(int AccountNumber, string AccountHolderName, double initialBalance)
//    {
//        this.AccountNumber = AccountNumber; // Assigning readonly variable
//        this.AccountHolderName = AccountHolderName;
//        this.Balance = initialBalance;
//        totalAccounts++; // Increment total accounts count
//    }

//    // Deposit method
//    public void Deposit(double amount)
//    {
//        if (amount > 0)
//        {
//            Balance += amount;
//            Console.WriteLine($"₹{amount} deposited successfully. New Balance: {Balance}");
//        }
//        else
//        {
//            Console.WriteLine("Invalid deposit amount.");
//        }
//    }

//    // Withdraw method
//    public void Withdraw(double amount)

//    {
//        if (amount > 20000 && amount <= Balance)
//        {
//            Balance -= amount;
//            Console.WriteLine($"₹{amount} withdrawn successfully. New Balance: {Balance}");
//        }
//        else
//        {
//            Console.WriteLine("Insufficient balance or invalid amount{May be ur amount is less than 2000}.");
//        }
//    }

//    // Display account details using 'is' operator
//    public void DisplayAccountInfo()
//    {
//        if (this is BankAccount)
//        {
//            Console.WriteLine("\n=== Account Details ===");
//            Console.WriteLine($"Bank Name: {bankName}");
//            Console.WriteLine($"Account Number: {AccountNumber}");
//            Console.WriteLine($"Account Holder: {AccountHolderName}");
//            Console.WriteLine($"Balance: {Balance}\n");
//        }
//        else
//        {
//            Console.WriteLine("Invalid account object.");
//        }
//    }

//    // Static method to get the total number of accounts
//    public static void GetTotalAccounts()
//    {
//        Console.WriteLine($"Total Bank Accounts: {totalAccounts}");
//    }
//}

//class Bank
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Welcome to State Bank of India");

//        // Creating an account
//        BankAccount myAccount = new BankAccount(101, "Muskan", 5000);



//        bool exit = false;

//        // Running loop until the user chooses to exit
//        while (!exit)
//        {
//            Console.WriteLine("\n===== BANK MENU =====");
//            Console.WriteLine("1. Deposit Money");
//            Console.WriteLine("2. Withdraw Money");
//            Console.WriteLine("3. View Account Details");
//            Console.WriteLine("4. Exit");
//            Console.Write("Choose an option: ");
//            int choice = Convert.ToInt32(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    Console.Write("Enter deposit amount: ₹");
//                    double deposit = Convert.ToDouble(Console.ReadLine());
//                    myAccount.Deposit(deposit);
//                    break;

//                case 2:
//                    Console.Write("Enter withdrawal amount: ₹");
//                    double withdraw = Convert.ToDouble(Console.ReadLine());
//                    myAccount.Withdraw(withdraw);
//                    break;

//                case 3:
//                    myAccount.DisplayAccountInfo();
//                    break;

//                case 4:
//                    Console.WriteLine("Exiting the system. Thank you!");
//                    exit = true;
//                    break;

//                default:
//                    Console.WriteLine("Invalid choice! Please select a valid option.");
//                    break;
//            }
//        }
//    }
//}
