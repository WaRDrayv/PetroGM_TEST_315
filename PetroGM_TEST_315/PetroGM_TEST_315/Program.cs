using MathObjFactory;
using MathObjFactory.MatObject;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = "./input.txt";
        var data = TxtParser.ParseFile(path);
        //Console.ReadLine();

        var list = TxtParser.ConvertToDataList(data);

        var objectsList = list.Select((item) => Factory.CreateObj(item.Item1, item.Item2, item.Item3, 
                                                                  item.Item4, item.Item5, item.Item6)).ToList();
        objectsList.ForEach((item) => item.Draw());

    }
}