using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSquare.Figure
{
    public class Circle : IFigure
    {
        public readonly double R;
        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius));
            R = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
