using RestricGenerics.Entities;
using RestricGenerics.Services;
using System.Globalization;
using System.Collections.Generic;

namespace RestricGenerics;
class Program
{
    static void Main(string[] args)
    {
        List<Products> prodList = new List<Products>();

        System.Console.Write("Enter the number of products:");
        int items = int.Parse(Console.ReadLine());

        for(int i = 0;i < items;i++)
        {
            string [] vecItems = Console.ReadLine().Split(',');
            double price = double.Parse(vecItems[1], CultureInfo.InvariantCulture);
            prodList.Add(new Products(vecItems[0], price));
        }

        CalculationService cs = new CalculationService();

        Products prod = cs.Max(prodList);

        System.Console.WriteLine("Most expansive:");
        System.Console.WriteLine(prod);
    }
}
