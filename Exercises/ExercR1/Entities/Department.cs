using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercR1.Entities
{
    public class Department
    {
        public string Name { get; set; }
        public Department(){}
        public Department(string name)
        {
            Name = name;
        }
    }
}