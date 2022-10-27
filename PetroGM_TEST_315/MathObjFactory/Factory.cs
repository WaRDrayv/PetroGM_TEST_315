using MathObjFactory.MatObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjFactory
{
    static internal class Factory
    {
        public enum ObjectType
        {
            point,
            rect,
            line,
            circle
        }

        static public IDraw CreateObj(ObjectType type, int x1, int y1, int x2 = 0, int y2 = 0, int radius = 0) =>
            type switch
            {
                ObjectType.point => new Point(x1, y1),
                ObjectType.rect => new Rect(x1, y1, x2, y2),
                ObjectType.line => new Line(x1, x2, y1, y2),
                ObjectType.circle => new Circle(x1, y1, radius),
                _ => throw new NotImplementedException()
            };
    }
}
