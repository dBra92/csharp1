using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfacez.Entities
{
    public class Contract
    {

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }
        public Contract() { }

        public Contract(int number, DateTime date, double totalValue)
        {
            this.Number = number;
            this.Date = date;
            this.TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}