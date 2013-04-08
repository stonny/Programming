using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankProject
{
    class BankTest
    {
        // Testing class
        static void Main(string[] args)
        {
            DepositAccount testAcc = new DepositAccount(Customer.Company, 346, 2);
            MortageAccount testAcc2 = new MortageAccount(Customer.Individual, 53253, 3);


            testAcc.depositMoney(25);
            testAcc.withdrawMoney(34);
            testAcc.CalculateInterest(3);

        }
    }
}
