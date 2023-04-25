using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox
{
    public class Circle : Shape, ISquare
    {
        private double _radius;
        public double Radius { get => _radius; }
        public Circle(double radius) 
        {
            _radius = radius;
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше нуля");
            }
        }
        
        public double GetSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
