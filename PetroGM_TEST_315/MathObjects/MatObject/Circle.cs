using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjects.MatObject
{
    internal class Circle : IDraw, IGeometryObject
    {
        private readonly string _type = "circle";
        private readonly int _x;
        private readonly int _y;
        private readonly int _radius;

        internal Circle(int x, int y, int radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public string Type => _type;

        public void Draw()
        {
            Console.WriteLine($"{Type} at ({_x}, {_y}), radius = {_radius}");
        }
    }
}
