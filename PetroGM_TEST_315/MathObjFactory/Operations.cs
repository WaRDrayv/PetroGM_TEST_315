using MathObjFactory.MatObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjFactory
{
    internal class Operations
    {
        void Interact(List<(Factory.ObjectType, int, int, int, int, int)> list)
        {
            for (int i = 0; i < list.Count; i++)
            {

            }
            
        }

        //public string PointRect(int pointX, int pointY, int rectX1, int rectX2, int rectY1, int rectY2)
        //{
        //    if ((pointX >= rectX1 && pointX <= rectX2) && (pointY >= rectY1 && pointY <= rectY2))
        //        return $"point and rect have intersection at ({pointX}, {pointY})";
        //    return "point cannot intersect rect";
        //}

        //public string PointLine(int pointX, int pointY, int lineX1, int lineX2, int lineY1, int lineY2)
        //{
        //    if ((pointX >= lineX1 && pointX <= lineX2) && (pointY >= lineY1 && pointY <= lineY2))
        //        return $"point and line have intersection at ({pointX}, {pointY})";
        //    return "point cannot intersect line";
        //}

        public string PointRectLine(Factory.ObjectType type, int pointX, int pointY, int rectLineX1, int rectLineX2, int rectLineY1, int rectLineY2)
        {
            string objType = type is Factory.ObjectType.rect ? "rect" : "line";
            if ((pointX >= rectLineX1 && pointX <= rectLineX2) && (pointY >= rectLineY1 && pointY <= rectLineY2))
                return $"point and {objType} have intersection at ({pointX}, {pointY})";
            return $"point cannot intersect {objType}";
        }

        public string PointCircle(int pointX, int pointY, int circleX, int circleY, int radius)
        {
            if ((pointX <= circleX + radius && pointX >= circleX - radius) && (pointY <= circleY + radius && pointY >= circleY - radius))
                return $"point and circle have intersection at ({pointX}, {pointY})";
            return "point cannot intersect circle";
                
        }

        public string RectLine(int rectX1, int rectX2, int rectY1, int rectY2, int lineX1, int lineX2, int lineY1, int lineY2)
        {
            int squareX = Math.Abs(rectX1 - rectX2);//Прибавим, что б получить абстракцию площади прямоугольника по оси Х
            int squareY = Math.Abs(rectY1 - rectY2);// -||- по оси Y

            if (((rectX1 <= lineX1 && rectX1 + squareX >= lineX1) && (rectY1 <= lineY1 && rectY1 + squareY >= lineY1)) ||
                 (rectX2 - squareX >= lineX2 && rectX2 <= lineX2) && (rectY2 - squareY >= lineY2 && rectY2 <= lineY2))
            {
                // Возможно все эти формулы ошибочны в перспективе
                var intersecX1 = lineX1 >= rectX1 && rectX1 + squareX <= lineX1 ? lineX1 : lineX1 - rectX1 + lineX2;
                var intersecY1 = rectY1 <= lineY1 && rectY1 + squareY >= lineY1 ? lineY1 : lineY1 - rectY2 + lineY2;
                var intersecX2 = rectX2 - squareX >= lineX2 && rectX2 <= lineX2 ? lineX2 : lineX2 - rectX2 + lineX1;
                var intersecY2 = rectY2 - squareY >= lineY2 && rectY2 <= lineY2 ? lineY2 : lineY2 - rectY1 + lineY1;//Тут ошибка

                return $"rect and line have intersection at ({intersecX1},{intersecY1}) ({intersecX2}, {intersecY2})";
            }
            return "rect cannot intersect line";
        }

        public string RectCircle(int rectX1, int rectX2, int rectY1, int rectY2, int circleX, int circleY, int radius)
        {
            if ((rectX1 >= circleX + radius || rectX2 <= circleX - radius) || (rectX1 <= circleX - radius || rectX2 >= circleX + radius) ||
                (rectY1 >= circleY + radius || rectY2 <= circleY - radius) || (rectY1 <= circleY - radius || rectY2 >= circleY + radius))
            {

                return $"rect and circle have intersection at ()";
            }
            return "rect cannot intersecr circle";
        }

        public string LineCircle (int lineX1, int lineX2, int lineY1, int lineY2, int circleX, int circleY, int radius)
        {
            if ((lineX1 >= circleX + radius || lineX2 <= circleX - radius) || (lineX1 <= circleX - radius || lineX2 >= circleX + radius) ||
                (lineY1 >= circleY + radius || lineY2 <= circleY - radius) || (lineY1 <= circleY - radius || lineY2 >= circleY + radius))
            {
                return $"line and circle have intersection at ()";
            }
            return "line cannot intersecr circle";
        }

    }
}
