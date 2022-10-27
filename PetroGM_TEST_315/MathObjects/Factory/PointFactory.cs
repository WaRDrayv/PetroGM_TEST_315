using MathObjects.MatObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjects.Factory
{
    internal class PointFactory : MatObjectFactory
    {
        //private readonly string _type;
        private readonly int _x;
        private readonly int _y;

        internal PointFactory(int x, int y)
        {
            //_type = type;
            _x = x;
            _y = y;
        }

        public override IGeometryObject Create()
        {
            Point point = new(_x, _y);
            return point;
        }
    }
}
