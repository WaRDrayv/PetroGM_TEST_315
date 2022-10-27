using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjects.MatObject
{
    internal class Rectangle : IDraw, IGeometryObject
    {
        private readonly string _type = "rect";
        private readonly int _x1;
        private readonly int _y1;
        private readonly int _x2;
        private readonly int _y2;

        internal Rectangle(int x1, int y1, int x2, int y2)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
        }

        public string Type => _type;

        public void Draw()
        {
            Console.WriteLine($"{Type} at ({_x1}, {_y1}), ({_x2}, {_y2})");
        }
    }
}
