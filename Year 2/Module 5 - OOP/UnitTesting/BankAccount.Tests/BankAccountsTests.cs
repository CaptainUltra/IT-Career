using System;
using NUnit.Framework;

namespace BankAccount.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void ValidateDepositAmmount()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(20);
            var expectedResult = 20;
            var actualResult = bankAccount.Ammount;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
