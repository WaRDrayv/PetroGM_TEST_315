using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjFactory.MatObject
{
    internal class Point : IDraw
    {
        private readonly string _type = "point";
        private int _x;
        private int _y;

        internal Point(int x, int y)
        {
            _x = x;
            _y = y;
        }


        public string Type => _type;

        public void Draw()
        {
            Console.WriteLine($"{Type} at ({_x}, {_y})");
        }
    }
}
