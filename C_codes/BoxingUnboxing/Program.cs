class Program
{
  static void Main()
  {
    var random = new Random();
    var objects = new List<object>();
    
    for (int i = 0; i < 10; i++)
    {
      if (random.Next(2) == 0)
      {
        objects.Add(random.Next(1, 101));
      }
      else
      {
        objects.Add((float)(random.NextDouble() * 100));
      }
    }

    Console.WriteLine("Элементы списка:");
    foreach (var item in objects)
    {
      Console.WriteLine($"{item} - {item.GetType().Name}");
    }
    
    double sum = SumObjects(objects);
    Console.WriteLine($"Сумма: {sum}");
  }
  
  static double SumObjects(List<object> objects)
  {
    double sum = 0;

    foreach (var obj in objects)
    {
      switch (obj)
      {
        case int i:
          sum += i;
          break;
        case float f:
          sum += f;
          break;
        default:
          throw new ArgumentException($"Неподдерживаемый тип: {obj?.GetType()}");
      }
    }

    return sum;
  }
}