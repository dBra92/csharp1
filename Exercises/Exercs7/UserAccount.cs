using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercs7
{
    public class UserAccount
    {
        public int Account { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public UserAccount()
        {

        }
        public UserAccount(int account, string holder)
        {
            Account = account;
            Holder = holder;
        }

        public UserAccount(int account, string holder, double balance) : this(account, holder)
        {
            Balance = balance;
        }


        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount + 5;
        }

        public override string ToString()
        {
            return Account + ", " + Holder + ", $" + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}