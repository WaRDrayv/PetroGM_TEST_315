using MathObjects.MatObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjects.Factory
{
    internal class CircleFactory : MatObjectFactory
    {
        private readonly int _x;
        private readonly int _y;
        private readonly int _radius;

        internal CircleFactory(int x, int y, int radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override IGeometryObject Create()
        {
            Circle circle = new(_x, _y, _radius);
            return circle;
        }
    }
}
