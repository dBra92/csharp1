using ExercR1.Entities.Enums;
using ExercR1.Entities;
using System.Globalization;

namespace ExercR1;
class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Enter department's name:");
        string departmentName = Console.ReadLine();

        System.Console.WriteLine("Enter worker data:");

        System.Console.Write("Name:");
        string name = Console.ReadLine();

        System.Console.Write("Level[Junior / Mid Level / Senior]:");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine().ToUpper());

        System.Console.Write("Base Salary $");
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Department dp = new Department(departmentName);
        Worker wk = new Worker(name, level, baseSalary, dp);

        System.Console.Write("How many contracts to this worker:");
        int qtt = int.Parse(Console.ReadLine());
        for (int i = 1; i <= qtt; i++)
        {
            System.Console.WriteLine($"Enter #{i} contract data:");

            System.Console.Write("Date[DD/MM/YYYY]:");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            System.Console.Write("Value per hour:");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Duration:");
            int duration = int.Parse(Console.ReadLine());

            HourContract hc = new HourContract(dateTime, valuePerHour, duration);
            wk.AddContract(hc);
        }

        System.Console.Write("Enter month and year to calculate income[MM/YYYY]:");
        string year_month = Console.ReadLine();

        int month = int.Parse(year_month.Substring(0, 2));
        int year = int.Parse(year_month.Substring(3));

        System.Console.WriteLine($"Name:{wk.Name}");
        System.Console.WriteLine($"Department:{dp.Name}");
        System.Console.WriteLine("Income for " + year_month + ":" + wk.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

    }
}
