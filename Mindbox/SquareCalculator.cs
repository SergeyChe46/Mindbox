using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox
{
    public class SquareCalculator
    {
        public double CalculateSquare(ISquare squarable)
        {
            return squarable.GetSquare();
        }
    }
}
