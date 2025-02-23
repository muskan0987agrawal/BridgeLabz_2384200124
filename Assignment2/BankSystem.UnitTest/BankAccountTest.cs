using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using BankSystem;

namespace BankSystem.UnitTest
{
    [TestFixture]
    public class BankAccountTest
    {
        private BankAccount account;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount();
        }

        [TestCase(1000, 500, 500)]  // Deposit 1000, Withdraw 500 → Balance should be 500
        [TestCase(200, 100, 100)]   // Deposit 200, Withdraw 100 → Balance should be 100
        [TestCase(50, 25, 25)]      // Deposit 50, Withdraw 25 → Balance should be 25
        public void DepositAndWithdraw_ShouldUpdateBalanceCorrectly(int deposit, int withdraw, int expectedBalance)
        {
            account.Deposit(deposit);
            account.Withdraw(withdraw);
            Assert.AreEqual(expectedBalance, account.Getter(), "Balance should be updated correctly.");
        }

        [TestCase(500, 1000)]  // Trying to withdraw 1000 when balance is 500
        [TestCase(300, 500)]   // Trying to withdraw 500 when balance is 300
        public void Withdraw_ShouldFail_WhenInsufficientFunds(int deposit, int withdraw)
        {
            account.Deposit(deposit);
            var ex = Assert.Throws<InvalidOperationException>(() => account.Withdraw(withdraw));
            Assert.That(ex.Message, Is.EqualTo("Insufficient funds."));
        }

        [TestCase(-100)]  // Trying to deposit a negative amount
        [TestCase(0)]     // Trying to deposit zero
        public void Deposit_ShouldThrowException_WhenAmountIsInvalid(int amount)
        {
            var ex = Assert.Throws<ArgumentException>(() => account.Deposit(amount));
            Assert.That(ex.Message, Is.EqualTo("Deposit amount must be positive."));
        }

        [TestCase(-50)]  // Trying to withdraw a negative amount
        [TestCase(0)]    // Trying to withdraw zero
        public void Withdraw_ShouldThrowException_WhenAmountIsInvalid(int amount)
        {
            var ex = Assert.Throws<ArgumentException>(() => account.Withdraw(amount));
            Assert.That(ex.Message, Is.EqualTo("Withdrawal amount must be positive."));
        }


    }
}
