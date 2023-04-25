using Mindbox;
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
            Circle circle = new Circle(radius);
            SquareCalculator squareCalculator = new SquareCalculator();

            // Act
            double circleSquare = squareCalculator.CalculateSquare(circle);

            // Assert
            Assert.Equal(Math.PI * Math.Pow(circle.Radius, 2), circleSquare);
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
