using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjects.Factory
{
    internal abstract class MatObjectFactory
    {
        public abstract IGeometryObject Create();
    }
}
