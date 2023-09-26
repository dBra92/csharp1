using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercs3
{
    public class Rectangle
    {
        public double Width;
        public double Height;

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return 2 * (Width + Height);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Width * Width + Height * Height);
        }

        public override string ToString()
        {
            return "AREA:" + Area().ToString("F2", CultureInfo.InvariantCulture) + "\n" + "PERIMETER:" + Perimeter().ToString("F2", CultureInfo.InvariantCulture) + "\n" +
            "DIAGONAL:" + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}