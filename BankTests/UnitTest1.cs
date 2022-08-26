using Bankkonto_ASP.NET;
using Bankkonto_ASP.NET.Controllers;

namespace BankTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WithdrawShouldWork()
        {
            // Arrange
            Bankkonto bankAccount = new Bankkonto();
            double balance = 100;

            // Act
            double result = bankAccount.Withdraw(99);

            // Assert
            Assert.AreEqual(result, -99);
        }

        [TestMethod]
        public void DepositShouldWork()
        {
            // Arrange
            Bankkonto bankAccount = new Bankkonto();
            double balance = 100;

            // Act
            double result = bankAccount.Deposit(99);

            // Assert
            Assert.AreEqual(result, 99);

        }

        [TestMethod]
        public void GetCashShouldWork()
        {
            // Arrange
            Bankkonto bankAccount = new Bankkonto();
            double balance = 100;

            // Act
            double result = bankAccount.GetCash();

            // Assert
            Assert.AreEqual(result, 0);
        }

    }
}