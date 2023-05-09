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
            ShapeFactory circleFactory = new CircleFactory(radius);
            Shape circle = circleFactory.Create();
            SquareCalculator squareCalculator = new SquareCalculator();

            double circleSquare = squareCalculator.CalculateSquare(circle);
            double expected = Math.PI * Math.Pow(radius, 2);
            Assert.Equal(expected, circleSquare);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-120)]
        public void NegativeRadiusException(double nonPositiveRadius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(nonPositiveRadius));
        }
    }
}
