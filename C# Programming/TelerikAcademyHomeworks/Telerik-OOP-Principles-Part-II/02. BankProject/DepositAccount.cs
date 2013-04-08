using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankProject
{
    public class DepositAccount : Accounts, IDepositable, IWithdrawable
    {
        // Constructor that uses the parameters from the base class
        public DepositAccount(Customer customer, double balance, double interestRate)
            : base(balance, interestRate, customer)
        {

        }

        // Overrided method as it has different usage in this class
        public override double CalculateInterest(ushort months)
        {
            if (Balance > 0 && Balance < 1000)
            {
                return 0;
            }
            else
            {
                return months * InterestRate;
            }
        }

        // Method that is implemented by the interface
        public void withdrawMoney(double money)
        {
            this.Balance -= money;
        }

        // Method that is implemented by the interface
        public void depositMoney(double money)
        {
            this.Balance += money;
        }
    }
}
