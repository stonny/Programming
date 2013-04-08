using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankProject
{
    public class MortageAccount : Accounts, IDepositable
    {
        // Constructor that uses the parameters from the base class
         public MortageAccount(Customer customer, double balance, double interestRate)
            : base(balance, interestRate, customer)
        {

        }

        // Overrided method that has different behaviour for this class
         public override double CalculateInterest(ushort months)
         {
             if (Customer == Customer.Individual)
             {
                 if (months > 6)
                 {
                     return (months - 6) * InterestRate;
                 }
                 else
                 {
                     return 0;
                 }
             }
             else
             {
                 if (months > 12)
                 {
                     return 12 * InterestRate / 2 + (12 - months) * InterestRate;
                 }
                 else
                 {
                     return months * InterestRate / 2;
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
