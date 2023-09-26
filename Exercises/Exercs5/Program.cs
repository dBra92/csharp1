using System.Globalization;

namespace Exercs5;
class Program
{
    static void Main(string[] args)
    {
        Student std = new Student();

        Console.Write("Student name:");
        std.StudentName = Console.ReadLine();
        Console.WriteLine("Enter to the three grades of student:");
        std.Grades = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        std.Grades2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        std.Grades3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double missing;

        if (std.Approved())
        {
            Console.WriteLine("APPROVED!");
            Console.WriteLine($"Grade final:{std.FinalGrade()}");
        }
        else
        {
            missing = 60 - std.FinalGrade();
            
            Console.WriteLine($"Grade final:{std.FinalGrade()}");
            Console.WriteLine($"REPROVED");
            Console.WriteLine($"Missing:{missing} points");
        }
    }
}
