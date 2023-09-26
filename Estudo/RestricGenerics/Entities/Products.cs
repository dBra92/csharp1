using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace RestricGenerics.Entities;

public class Products : IComparable
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Products(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public int CompareTo(object obj)
    {
        if(!(obj is Products))
        {
            throw new ArgumentException("Comparing error: argument is not an Product");
        }
        Products other = obj as Products;
        return Price.CompareTo(other.Price);
    }

    public override string ToString()
    {
        return Name +", "+Price.ToString("F2", CultureInfo.InvariantCulture);
    }
}
