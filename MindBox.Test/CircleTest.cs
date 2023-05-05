using Mindbox;
using Mindbox.Factories;
using Mindbox.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Test
{
    public class CircleTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(200)]
        public void ReturnRightSquare(double radius)
        {
            // Arrange
            ShapeFactory circleFactory = new CircleFactory(radius);
            Shape circle = circleFactory.Create();
            SquareCalculator squareCalculator = new SquareCalculator();

            // Act
            double circleSquare = squareCalculator.CalculateSquare(circle);
            double expected = Math.PI * Math.Pow(((Circle)circle).Radius, 2);
            // Assert
            Assert.Equal(expected, circleSquare);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-120)]
        public void NegativeRadiusException(double nonPositiveRadius)
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(nonPositiveRadius));
        }
    }
}
