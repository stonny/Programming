using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankProject
{
    // Interface that allows withdraw from accounts
    public interface IWithdrawable
    {
        void withdrawMoney(double withdraw);
    }
}
