using Mindbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Test
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 10, 15)]
        [InlineData(42, 42, 42)]
        public void ReturnRightSquare(double sideA, double sideB ,double sideC)
        {
            // Arrange
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            SquareCalculator squareCalculator = new SquareCalculator();

            // Act
            double hp = (sideA + sideB + sideC) / 2;
            double triangleSquare = squareCalculator.CalculateSquare(triangle);

            // Assert
            double square = Math.Sqrt(hp * (hp - sideA) * (hp - sideB) * (hp - sideC));
            Assert.Equal(square, triangleSquare);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(5, 12, 13)]
        [InlineData(8, 15, 17)]
        public void ReturnIsSquareness(double sideA, double sideB, double sideC)
        {
            // Arrange
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isSquareness = triangle.IsSquareness(new double[] { sideA, sideB, sideC });

            // Assert
            Assert.True(isSquareness);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(7, 8, 9)]
        public void ReturnIsNotSquareness(double sideA, double sideB, double sideC)
        {
            // Arrange
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isSquareness = triangle.IsSquareness(new double[] { sideA, sideB, sideC });

            // Assert
            Assert.False(isSquareness);
        }

        [Theory]
        [InlineData(0, -1, -2)]
        [InlineData(0, 1, -2)]
        [InlineData(0, 0, 0)]
        public void NonPositiveSidesException(double sideA, double sideB, double sideC)
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
    }
}
