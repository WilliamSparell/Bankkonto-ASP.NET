using Microsoft.AspNetCore.Mvc;
namespace Bankkonto_ASP.NET.Controllers
{
    public class Bankkonto
    {
        double cash = 0;

        public double Deposit(double amount)
        {
            return cash += amount;
        }

        public double Withdraw(double amount)
        {
            return cash -= amount;
        }

        public double GetCash()
        {
            return cash;
        }
    }
}
