using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjFactory.MatObject
{
    internal class Line : IDraw
    {
        private readonly string _type = "line";
        private int _x1;
        private int _x2;
        private int _y1;
        private int _y2;

        internal Line(int x1, int x2, int y1, int y2)
        {
            _x1 = x1;
            _x2 = x2;
            _y1 = y1;
            _y2 = y2;
        }

        public string Type => _type;

        public void Draw()
        {
            Console.WriteLine($"{Type} at ({_x1}, {_x2}), ({_y1}, {_y2})");
        }
    }
}
