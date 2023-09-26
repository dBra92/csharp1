using System.Globalization;

namespace Exercs6;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quotation dollar today:");
        double quotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("How many do you buy:");
        double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double total = CoinConversor.DolarToReal(amount, quotation);
        Console.WriteLine($"Total to pay in R$:{total}");
    }
}
