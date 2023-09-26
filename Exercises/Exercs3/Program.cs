using System.Globalization;

namespace Exercs3;
class Program
{
    static void Main(string[] args)
    {
        Rectangle rctg = new Rectangle();

        Console.Write("Enter the Width and Height of Rectangle:");
        rctg.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        rctg.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"{rctg}");
    }
}
