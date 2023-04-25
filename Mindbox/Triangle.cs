using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox
{
    public class Triangle : Shape, ISquare
    {
        private double _a, _b, _c;
        private double firstCatet, secondCatet, hipotenusa;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны должны быть неотрицательными");
            }
            _a = sideA;
            _b = sideB;
            _c = sideC;
        }

        public double GetSquare()
        {
            double square;
            if (IsSquareness(new double[]{ _a, _b, _c}))
            {
                square = (firstCatet * secondCatet) / 2;
            }
            else
            {
                double hp = HalfPerimeter();
                square = Math.Sqrt(hp * (hp -_a) * (hp - _b) * (hp - _c));
            }
            
            return square;
        }

        /// <summary>
        /// Полупериметр для вычисления площади не прямоугольного треугольника.
        /// </summary>
        /// <returns></returns>
        private double HalfPerimeter()
        {
            return (_a + _b + _c) / 2;
        }

        #region IsSquareness
        /// <summary>
        /// Проверяет треугольник на прямоугольность.
        /// </summary>
        /// <returns></returns>
        public bool IsSquareness(double[] inputedSides)
        {
            double[] sides = inputedSides;
            // Самая длинная сторона это гипотенуза.
            hipotenusa = sides.Max();
            // Остальные две - катеты.
            sides.ToList().Remove(hipotenusa);
            firstCatet = sides[0];
            secondCatet = sides[1];
            // Если треугольник НЕ прямоугольный, то вернёт false.
            bool isSquareness = Math.Pow(hipotenusa, 2) == Math.Pow(firstCatet, 2) + Math.Pow(secondCatet, 2);
            Console.WriteLine($"Треугольник {(isSquareness ? "" : "не ")}прямоугольный");
            return isSquareness;
        }
        #endregion
    }
}
