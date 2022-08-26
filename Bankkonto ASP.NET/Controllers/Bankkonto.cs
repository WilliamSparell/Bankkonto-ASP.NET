using Microsoft.AspNetCore.Mvc;
namespace Bankkonto_ASP.NET.Controllers
{
    public class Bankkonto
    {
        double cash = 0;

        double Deposit(double amount)
        {
            return cash += amount;
        }

        double Withdraw(double amount)
        {
            return cash -= amount;
        }

        double GetCash()
        {
            return cash;
        }
    }
}
