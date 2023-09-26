using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercs6
{
    public class CoinConversor
    {
        public static double IOF = 6.0;

        public static double DolarToReal(double amount, double quotation)
        {
            double total = amount * quotation;
            return total + total * IOF / 100.0;
        }
    }
}