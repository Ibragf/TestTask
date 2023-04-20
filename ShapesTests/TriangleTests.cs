using FiguresSquare;
using FiguresSquare.Figure;

namespace ShapesTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(5, 4, 3, true)]
        [TestCase(4, 5, 3, true)]
        [TestCase(100, 250, 176, false)]
        [TestCase(7.101, 0.904, 7.6, false)]
        public void GIVEN_rectangular_triangle_WHEN_IsRectangular_is_invoked_THEN_correct_value_is_returned(double a, double b, double c, bool expected)
        {
            // Arrange
            var figure = new Triangle(a, b, c);

            // Act
            var actual = figure.IsRectangular();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7.101, 0.904, 7.6, 2.7651619646253924)]
        [TestCase(158.0005, 67.1234, 100.5, 2161.2090896537707)]
        [TestCase(6234, 967.8910, 5432.99, 1579262.7804224908)]
        [TestCase(0.0801, 0.04509, 0.056, 0.0012234312316742706)]
        public void GIVEN_triangle_with_double_sides_WHEN_GetArea_is_invoked_THEN_correct_value_is_returned(double a, double b, double c, double expected)
        {
            // Arrange
            IFigure figure = new Triangle(a, b, c);

            // Act
            var actual = figure.GetArea();

            // Assert
            Assert.AreEqual(expected, actual);
        }



        [TestCase(6, 10, 14, 25.98076211353316)]
        [TestCase(5, 5, 5, 10.825317547305483)]
        [TestCase(100, 250, 176, 6963.1055571490515)]
        [TestCase(12306, 67870, 60099, 303854329.52282554)]
        public void GIVEN_triangle_with_integer_sides_WHEN_GetArea_is_invoked_THEN_correct_value_is_returned(int a, int b, int c, double expected)
        {
            // Arrange
            IFigure figure = new Triangle(a, b, c);

            // Act
            var actual = figure.GetArea();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 10, 16)]
        [TestCase(0, 0, 0)]
        [TestCase(2, 2, 4)]
        [TestCase(6.0001, 0.004, 7)]
        [TestCase(-1, -5, -6)]
        [TestCase(-7.101, 0.904, -7.6)]
        public void GIVEN_triangle_with_incorrect_sides_WHEN_GetSquare_is_invoked_THEN_exception_thrown(double a, double b, double c)
        {
            // Arrange
            IFigure figure;

            // Act
            TestDelegate act = () => figure = new Triangle(a, b, c);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }
    }
}