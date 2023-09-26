using System.Globalization;

namespace Exercs2;
class Program
{
    static void Main(string[] args)
    {
        Employee dEmp1 = new Employee();
        Employee dEmp2 = new Employee();

        Console.Write("Employee 1: Name - ");
        dEmp1.employeeName = Console.ReadLine();

        Console.Write("Employee 1: Salary - ");
        dEmp1.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();

        Console.Write("Employee 2: Name - ");
        dEmp2.employeeName = Console.ReadLine();

        Console.Write("Employee 2: Salary - ");
        dEmp2.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double avg = (dEmp1.salary + dEmp2.salary) / 2.0;
        Console.WriteLine($"Average salary $ {avg}");
    }
}
