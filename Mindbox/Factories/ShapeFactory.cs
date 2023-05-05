using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox.Shapes;

namespace Mindbox.Factories
{
    /// <summary>
    /// Реализовать для создания каждой новой фигуры.
    /// </summary>
    public abstract class ShapeFactory
    {
        public abstract Shape Create();
    }
}
