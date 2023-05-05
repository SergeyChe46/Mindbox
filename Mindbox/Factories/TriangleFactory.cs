using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox.Shapes;

namespace Mindbox.Factories
{
    /// <summary>
    /// Создаёт треугольник с заданными сторонами.
    /// </summary>
    public class TriangleFactory : ShapeFactory
    {
        private readonly double _sideA, _sideB, _sideC;

        public TriangleFactory(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override Shape Create()
        {
            return new Triangle(_sideA, _sideB, _sideC);
        }
    }
}
