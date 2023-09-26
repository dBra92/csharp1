using System.Globalization;

namespace Exercs4;
class Program
{
    static void Main(string[] args)
    {
        EmployeeData empD = new EmployeeData();
        Console.Write("Name:");
        empD.Name = Console.ReadLine();

        Console.Write("Gross salary:");
        empD.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Tax:");
        empD.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.Write($"{empD}");
        Console.WriteLine();

        Console.WriteLine();
        Console.Write("Enter the percentage to increase the salary:");
        Console.WriteLine();
        
        double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        empD.IncreaseSalary(percentage);

        Console.WriteLine($"Updated data:{empD}");
    }
}
