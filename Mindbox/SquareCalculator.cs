using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox.Shapes;

namespace Mindbox
{
    public class SquareCalculator
    {
        /// <summary>
        /// Возвращает площадь полученной фигуры.
        /// </summary>
        /// <param name="squarable">Фигура.</param>
        /// <returns>Площадь полученной фигуры.</returns>
        public double CalculateSquare(Shape squarable)
        {
            return squarable.GetSquare();
        }
    }
}
