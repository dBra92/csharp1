using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercs4
{
    public class EmployeeData
    {
        // Exerc28
        //Class EmployeeData
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double percentage)
        {
            GrossSalary += (GrossSalary * percentage / 100.0);
        }

        public override string ToString()
        {
            return "Employee:" + Name + "," + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}