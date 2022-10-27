using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjects.MatObject
{
    internal class Point : IDraw, IGeometryObject 
    {
        private readonly string _type = "point";
        private int _x;
        private int _y;

        internal Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        //public int X { get { return _x; } set { _x = value; } }
        //public int Y { get { return _y; } set { _y = value; } }


        public string Type => _type;

        public void Draw()
        {
            Console.WriteLine($"{Type} at ({_x}, {_y})");
        }
    }
}
