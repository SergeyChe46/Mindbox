using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox.Shapes;

namespace Mindbox.Factories
{
    /// <summary>
    /// Создаёт круг с заданным радиусом.
    /// </summary>
    public class CircleFactory : ShapeFactory
    {
        private readonly double _radius;

        public CircleFactory(double radius)
        {
            _radius = radius;
        }

        public override Shape Create()
        {
            return new Circle(_radius);
        }
    }
}
