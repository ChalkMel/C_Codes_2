namespace GeneralizedMethod;
using System.Numerics;

class Program
{
  static void Main()
  {
    var circle1 = new Circle<int>(new Vector2(0, 0), 5);
    var circle2 = new Circle<string>(new Vector2(1, 1), "7");
    var circle3 = new Circle<double>(new Vector2(2, 2), 3.2);
    var circle4 = new Circle<float>(new Vector2(3, 3), 2.4f);

    Console.WriteLine("До изменения радиусов");
    Console.WriteLine($"circle1: {circle1}");
    Console.WriteLine($"circle2: {circle2}");
    Console.WriteLine($"circle3: {circle3}");
    Console.WriteLine($"circle4: {circle4}");
    
    circle1.SetRadius(10);
    circle2.SetRadius("14");
    circle3.SetRadius(6.4);
    circle4.SetRadius(4.8f);

    Console.WriteLine();
    Console.WriteLine("После изменения радиусов");
    Console.WriteLine($"circle1: {circle1}");
    Console.WriteLine($"circle2: {circle2}");
    Console.WriteLine($"circle3: {circle3}");
    Console.WriteLine($"circle4: {circle4}");
  }
}