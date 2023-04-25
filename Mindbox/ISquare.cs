using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox
{
    public interface ISquare
    {
        /// <summary>
        /// Возвращает площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public abstract double GetSquare();
    }
}
