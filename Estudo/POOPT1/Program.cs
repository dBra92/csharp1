using System.Globalization;

namespace POO;
class Program
{
    static void Main(string[] args)
    {
        Triangle x, y;

        x = new Triangle();
        y = new Triangle();

        Console.WriteLine("Enter with to the measurements of triangle X:");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Enter with to the measurements of triangle Y:");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double areaX = x.Area();
        double areaY = y.Area();

        Console.WriteLine("Area X:" + areaX.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Area Y:" + areaY.ToString("F4", CultureInfo.InvariantCulture));

        if (areaX > areaY)
        {
            Console.WriteLine("Big area: X.");
        }
        else
        {
            Console.WriteLine("Big area: Y.");
        }
    }
}
