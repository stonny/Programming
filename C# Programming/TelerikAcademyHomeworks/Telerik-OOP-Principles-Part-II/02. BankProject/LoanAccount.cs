using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankProject
{
    public class LoanAccount : Accounts, IDepositable
    {
        // Constructor that uses the parameters from the base class
        public LoanAccount(Customer customer, double balance, double interestRate)
            : base(balance, interestRate, customer)
        {

        }

        // Overrided Methods as they have different usage in this class
        public override double CalculateInterest(ushort months)
        {
            if (Customer == Customer.Individual)
            {
                if (months > 3)
                {
                    return (months - 3) * InterestRate;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (months > 2)
                {
                    return (months - 2) * InterestRate;
                }
                else
                {
                    return 0;
                }
            }
        }

        // Method that is implemented by the interface
        public void depositMoney(double money)
        {
            this.Balance += money;
        }
    }
}
