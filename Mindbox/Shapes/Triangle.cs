using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Shapes
{
    public class Triangle : Shape
    {
        private double _sideA, _sideB, _sideC;
        private double firstCatet, secondCatet, hipotenusa;

        public double SideA
        {
            get => _sideA;
            set => _sideA = value > 0 ? value : throw new ArgumentException("Сторона должна быть больше нуля");
        }
        public double SideB
        {
            get => _sideB;
            set => _sideB = value > 0 ? value : throw new ArgumentException("Сторона должна быть больше нуля");
        }
        public double SideC
        {
            get => _sideC;
            set => _sideC = value > 0 ? value : throw new ArgumentException("Сторона должна быть больше нуля");
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double GetSquare()
        {
            double square;
            if (IsSquareness(new double[] { _sideA, _sideB, _sideC }))
            {
                square = firstCatet * secondCatet / 2;
            }
            else
            {
                double hp = HalfPerimeter();
                square = Math.Sqrt(hp * (hp - _sideA) * (hp - _sideB) * (hp - _sideC));
            }

            return square;
        }

        /// <summary>
        /// Полупериметр для вычисления площади не прямоугольного треугольника.
        /// </summary>
        /// <returns>Полупериметр.</returns>
        private double HalfPerimeter()
        {
            return (_sideA + _sideB + _sideC) / 2;
        }

        #region IsSquareness
        /// <summary>
        /// Проверяет треугольник на прямоугольность.
        /// </summary>
        /// <returns></returns>
        public bool IsSquareness(double[] inputedSides)
        {
            Array.Sort(inputedSides);
            // Самая длинная сторона - последняя в сортированном массиве - гипотенуза.
            // Остальные две - катеты.
            hipotenusa = inputedSides[^1];
            firstCatet = inputedSides[0];
            secondCatet = inputedSides[1];
            // Если треугольник НЕ прямоугольный, то вернёт false.
            bool isSquareness = Math.Pow(hipotenusa, 2) == Math.Pow(firstCatet, 2) + Math.Pow(secondCatet, 2);
            Console.WriteLine($"Треугольник {(isSquareness ? "" : "не ")}прямоугольный");
            return isSquareness;
        }
        #endregion
    }
}
