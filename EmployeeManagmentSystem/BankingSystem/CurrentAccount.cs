using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem;
    internal class CurrentAccount : BankAccount, ILoanable
{
    
    public override double CalculateInterest()
    {
        return 0; // No interest for Current Account
    }
    public void ApplyForLoan()
    {
        Console.WriteLine("Loan applied for current Account!");
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 3; // Eligible for 3x balance loan;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        ApplyForLoan();
        Console.WriteLine($"Loan Eligiblity: {CalculateLoanEligibility}");
    }
}
