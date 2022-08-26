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

        public void DepositShouldWork()
        { 
            // Arrange
            // Act
            // Assert        
        }

        public void GetCashShouldWork()
        {
            // Arrange
            // Act
            // Assert        
        }

    }
}