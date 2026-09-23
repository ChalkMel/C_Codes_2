namespace GeneralizedClassSeveral;
using System.Numerics;

class Program
{
  static void Main()
  {
    var rect1 = new Rectangle<string, int>(
      new Vector2(0, 0), "4", 2);

    var rect2 = new Rectangle<float, double>(
      new Vector2(1.5f, 2.5f), 2.5f, 3.3);

    var rect3 = new Rectangle<string, float>(
      new Vector2(-2, 3), "3", 4.2f);

    PrintFigure("rect1", rect1);
    PrintFigure("rect2", rect2);
    PrintFigure("rect3", rect3);
  }

  static void PrintFigure(string name, Figure figure)
  {
    Console.WriteLine($"{name}: {figure}");
    Console.WriteLine($"  MinPoint = ({figure.MinPoint.X}; {figure.MinPoint.Y})");
    Console.WriteLine($"  MaxPoint = ({figure.MaxPoint.X}; {figure.MaxPoint.Y})");
    Console.WriteLine();
  }
}