using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSquare
{
    public class FigureCalculator
    {
        public static double CalculateFigureArea(IFigure figure)
        {
            return figure.GetArea();
        }
    }
}
