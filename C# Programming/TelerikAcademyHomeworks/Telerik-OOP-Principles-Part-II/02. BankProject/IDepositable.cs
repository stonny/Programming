using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankProject
{
    // Interface that allows Deposit for accounts
    public interface IDepositable
    {
        void depositMoney(double money);
    }
}
