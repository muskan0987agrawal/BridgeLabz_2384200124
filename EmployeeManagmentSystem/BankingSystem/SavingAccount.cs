using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class SavingAccount: BankAccount, ILoanable
    {
        public override double CalculateInterest()
        {
            return Balance * 0.04; //4% interest
        }
        public void ApplyForLoan()
        {
            Console.WriteLine("Loan applied for Savings Account!");
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 5; // Eligible for 5x balance loan;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine(ApplyForLoan);
            Console.WriteLine($"Loan Eligiblity: {CalculateLoanEligibility}");
        }
    }
   
}
