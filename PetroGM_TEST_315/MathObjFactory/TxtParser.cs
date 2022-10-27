using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjFactory
{
    static internal class TxtParser
    {

        static public string[] ParseFile (string path)
        {
            var reader = new StreamReader (path);
            var data = reader.ReadToEnd ();
            reader.Close ();
            return data.Split("\r\n");
        }

        static public List<(Factory.ObjectType, int, int, int, int, int)> ConvertToDataList(string[] data)
        {
            var list = new List<(Factory.ObjectType, int, int, int, int, int)>();
            foreach (var item in data)
            {
                var splitData = item.Split();
                switch (splitData[0])
                {
                    case "point":
                        list.Add((Factory.ObjectType.point, Int32.Parse(splitData[1]),
                                  Int32.Parse(splitData[2]), 0, 0, 0));
                        break;

                    case "rect":
                        list.Add((Factory.ObjectType.rect, Int32.Parse(splitData[1]),
                                  Int32.Parse(splitData[2]), Int32.Parse(splitData[3]),
                                  Int32.Parse(splitData[4]), 0));
                        break;

                    case "line":
                        list.Add((Factory.ObjectType.line, Int32.Parse(splitData[1]),
                                  Int32.Parse(splitData[2]), Int32.Parse(splitData[3]),
                                  Int32.Parse(splitData[4]), 0));
                        break;

                    case "circle":
                        list.Add((Factory.ObjectType.circle, Int32.Parse(splitData[1]),
                                  Int32.Parse(splitData[2]), 0,
                                  0, Int32.Parse(splitData[3])));
                        break;
                    default:
                        break;
                };
            }
            return list;
        }

    }
}
