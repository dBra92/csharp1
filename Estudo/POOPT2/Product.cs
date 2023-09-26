using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOPT2
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Quantitie;

        public double TotalValueInStock()
        {
            return Price * Quantitie;
        }

        public void AddProduct(int quantitie)
        {
            Quantitie += quantitie;
        }
        public void RmvProduct(int quantitie)
        {
            Quantitie -= quantitie;
        }

        public override string ToString()
        {
            return Name + ", $" + Price + ", " + Quantitie + " units, Total:" + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}