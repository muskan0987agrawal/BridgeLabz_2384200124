// See https://aka.ms/new-console-template for more information

using BankingSystem;

class Program3
{
    public static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();

        while (true)
        {
            Console.WriteLine("1. Create saving Account");
            Console.WriteLine("2. Create Current Account");
            Console.WriteLine("3.Add Amount");
            Console.WriteLine("4. Withdraw Amount");

            Console.WriteLine("Enter ur choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    SavingAccount saving = new SavingAccount();
                    Console.Write("Enter Account Number: ");
                    saving.AccountNumber = Console.ReadLine();
                    Console.Write("Enter Holder Name: ");
                    saving.HolderName = Console.ReadLine();
                    Console.Write("Enter Initial Balance: ");
                    saving.Deposit(Convert.ToDouble(Console.ReadLine()));
                    saving.DisplayDetails();
                    accounts.Add(saving);
                    Console.WriteLine("Savings Account Created!\n");
                    break;

                case 2:
                    CurrentAccount current = new CurrentAccount();
                    Console.Write("Enter Account Number: ");
                    current.AccountNumber = Console.ReadLine();
                    Console.Write("Enter Holder Name: ");
                    current.HolderName = Console.ReadLine();
                    Console.Write("Enter Initial Balance: ");
                    current.Deposit(Convert.ToDouble(Console.ReadLine()));
                    current.DisplayDetails();
                    accounts.Add(current);
                    Console.WriteLine("Current Account Created!\n");
                    break;

                case 3:
                    Console.Write("Enter Account Number: ");
                    string accNo = Console.ReadLine();  // Changed to string
                    BankAccount acc = accounts.FirstOrDefault(a => a.AccountNumber == accNo);  // Fixed search logic

                    if (acc != null)
                    {
                        Console.Write("Enter Amount to Deposit: ");
                        acc.Deposit(Convert.ToDouble(Console.ReadLine()));
                    }
                    else
                    {
                        Console.WriteLine(" Account Not Found!");
                    }
                    break;

                case 4:
                    Console.Write("Enter Account Number: ");
                    string accNoWithdraw = Console.ReadLine();  // ✅ Changed to string
                    BankAccount accWithdraw = accounts.FirstOrDefault(a => a.AccountNumber == accNoWithdraw);

                    if (accWithdraw != null)
                    {
                        Console.Write("Enter Amount to Withdraw: ");
                        accWithdraw.Withdraw(Convert.ToDouble(Console.ReadLine()));
                    }
                    else
                    {
                        Console.WriteLine("❌ Account Not Found!");
                    }
                    break;

                case 5:
                    Console.WriteLine("✅ Exiting the program.");
                    return;

                default:
                    Console.WriteLine("❌ Invalid Choice! Please select a valid option.");
                    break;
            }
        }
    }
}
    


