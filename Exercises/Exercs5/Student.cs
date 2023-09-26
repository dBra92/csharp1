using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercs5
{
    public class Student
    {
        public string StudentName;
        public double Grades;
        public double Grades2;
        public double Grades3;

        public double FinalGrade()
        {
            return Grades + Grades2 + Grades3;
        }

        public bool Approved()
        {
            if(FinalGrade() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double RemainingGrade()
        {
            if(Approved())
            {
                return 0.0;
            }
            else
            {
                return 60 - FinalGrade();
            }
        }
    }
}