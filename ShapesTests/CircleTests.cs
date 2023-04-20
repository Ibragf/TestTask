using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresSquare;
using FiguresSquare.Figure;
using NUnit.Framework;

namespace ShapesTests
{
    class CircleTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(0, 0)]
        [TestCase(1, 3.141592653589793)]
        [TestCase(10, 314.1592653589793)]
        [TestCase(50, 7853.981633974483)]
        [TestCase(333, 348368.06776391855)]
        public void GIVEN_circle_with_integer_radius_WHEN_GetArea_is_invoked_THEN_correct_value_is_returned(int r, double expected)
        {
            // Arrange
            IFigure figure = new Circle(r);

            // Act
            var actual = figure.GetArea();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0.01, 0.0003141592653589793)]
        [TestCase(1.1, 3.8013271108436504)]
        [TestCase(15.005, 707.3296644955583)]
        [TestCase(99.1099, 30859.14922648169)]
        [TestCase(105.70906, 35105.429806322594)]
        public void GIVEN_circle_with_double_radius_WHEN_GetArea_is_invoked_THEN_correct_value_is_returned(double r, double expected)
        {
            // Arrange
            IFigure figure = new Circle(r);

            // Act
            var actual = figure.GetArea();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1)]
        [TestCase(-90000)]
        [TestCase(-1.111)]
        [TestCase(-0.00001)]
        [TestCase(double.MinValue)]
        public void GIVEN_circle_with_incorrect_radius_WHEN_GetArea_is_invoked_THEN_exception_is_thrown(double r)
        {
            // Arrange
            IFigure figure;

            // Act
            TestDelegate act = () => figure = new Circle(r);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }

    }
}
