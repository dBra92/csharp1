using System.Collections.Generic;
using System.Globalization;
namespace Exercs9;
class Program
{
    static void Main(string[] args)
    {
        List<Employee> emp = new List<Employee>();

        Console.Write("How many employees will be registered?");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Employee#{i}");
            Console.Write("ID:");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Salary $");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            emp.Add(new Employee(id, name, salary));
        }

        Console.WriteLine();
        Console.Write("Enter the employee id that will have salary increase:");
        int findId = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Employee emp2 = emp.Find(x => x.Id == findId);
        if (emp2 != null)
        {
            Console.Write("Enter the percentage:");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp2.Increase(percentage);
        }
        else
        {
            Console.WriteLine("This id does not exist");
        }
        Console.WriteLine();
        Console.WriteLine("Updated list of employees:");
        foreach (Employee emp3 in emp)
        {
            Console.WriteLine(emp3);
        }
    }
}
