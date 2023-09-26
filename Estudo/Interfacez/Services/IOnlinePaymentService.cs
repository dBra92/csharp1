using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfacez.Services
{
    public interface IOnlinePaymentService
    {
        double Interest(double amount, int months);
        double PaymentFee(double amount);

    }
}