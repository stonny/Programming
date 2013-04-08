using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankProject
{
    // Main class that will be inherited
    public abstract class Accounts
    {
        private double balance;
        private double interestRate;
        private Customer customer;
        // Main Constructor that will be used
        public Accounts(double balance, double interestRate, Customer customer)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Customer = customer;
        }

        // Properties
        public double Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                this.interestRate = value;
            }
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }
    
        // Virtual method that will be overrided
        public virtual double CalculateInterest(ushort months)
        {
            return (this.Balance * this.InterestRate) * months;
        }
    }
}
