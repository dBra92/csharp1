using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercs9
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary}";
        }

        public void Increase(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }
    }
}