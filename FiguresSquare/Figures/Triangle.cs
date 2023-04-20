using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSquare.Figure
{
    public class Triangle : IFigure
    {
        public double A
        {
            get { return sides[0]; }
        }
        public double B
        {
            get { return sides[1]; }
        }
        public double C
        {
            get { return sides[2]; }
        }

        private readonly double[] sides;
        public Triangle(double a, double b, double c)
        {
            if (a < 0) throw new ArgumentOutOfRangeException(nameof(a));
            if (b < 0) throw new ArgumentOutOfRangeException(nameof(b));
            if (c < 0) throw new ArgumentOutOfRangeException(nameof(c));

            if (a + b <= c || a + c <= b || c + b <= a)
                throw new ArgumentOutOfRangeException(
                    "The sum of the lengths of any two sides of the triangle should not be less than the length of the third side.");

            sides = new double[] { a, b, c };
        }

        public double Semiperimeter => (A + B + C) / 2;

        public double GetArea()
        {
            return Math.Sqrt(Semiperimeter
                             * (Semiperimeter - A)
                             * (Semiperimeter - B)
                             * (Semiperimeter - C));
        }

        public bool IsRectangular()
        {
            var maxSide = sides.Max();

            return sides.Where(side => side != maxSide)
                        .Select(side => Math.Pow(side, 2))
                        .Sum()
                        .Equals(Math.Pow(maxSide, 2));
        }
    }

}
