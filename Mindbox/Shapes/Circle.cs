using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Shapes
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            set => _radius = value > 0 ? value : throw new ArgumentException("Радиус должен быть больше нуля");
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
