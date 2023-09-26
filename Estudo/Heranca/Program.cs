using Heranca.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Heranca;
class Program
{
    static void Main(string[] args)
    {
        List<Account> accList = new List<Account>();

        accList.Add(new SavingsAccount(0001,"Bob" , 500.0 , 0.01));
        accList.Add(new BusinessAccount(0002, "Helena", 500.0, 400.0));
        accList.Add(new SavingAccount(0003, "Jack", 500.0 , 0.01));
        accList.Add(new BusinesAccount(0004, "Maria" , 350.0, 700.0));

        double sum = 0.0;
        foreach(Account acc2 in accList)
        {
            sum += acc2.Balance;
        }

        System.Console.WriteLine("Total balance:"+sum.ToString("F2", CultureInfo.InvariantCulture));
    }
}

