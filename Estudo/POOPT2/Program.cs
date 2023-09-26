using System.Globalization;
namespace POOPT2;
class Program
{
    static void Main(string[] args)
    {
        Product prod = new Product();
        Console.WriteLine("Enter with the data of product:");

        Console.Write("Name:");
        prod.Name = Console.ReadLine();

        Console.Write("Price:");
        prod.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Quantitie in stock:");
        prod.Quantitie = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(prod);
        Console.WriteLine();

        Console.Write("Enter the number of products to add to stock:");
        int quantitie = int.Parse(Console.ReadLine());
        prod.AddProduct(quantitie);

        Console.WriteLine();
        Console.WriteLine($"Update:{prod}");
        Console.WriteLine();

        Console.Write("Enter the number of products to be removed from stock:");
        quantitie = int.Parse(Console.ReadLine());
        prod.RmvProduct(quantitie);
        
        Console.WriteLine();
        Console.WriteLine($"Update pt 2:{prod}");
    }
}
