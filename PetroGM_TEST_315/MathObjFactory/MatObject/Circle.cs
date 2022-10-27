using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjFactory.MatObject
{
    internal class Circle : IDraw
    {
        private readonly string _type = "circle";
        private int _x;
        private int _y;
        private int _radius;

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
