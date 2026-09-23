namespace Default_values;

class Program
{
  static void Main()
  {
    var intContainer = new Container<int>(42);
    
    var bookContainer = new Container<Book<string>>(
      new Book<string>("B0666", "Тася и граф", "Арсений Попов", 358)
    );

    Console.WriteLine("До Reset");
    Console.WriteLine($"intContainer.Value   = {intContainer.Value}");
    Console.WriteLine($"bookContainer.Value  = {bookContainer.Value}");
    
    intContainer.Reset();
    bookContainer.Reset();

    Console.WriteLine();
    Console.WriteLine("После Reset");
    Console.WriteLine($"intContainer.Value   = {intContainer.Value}");
    Console.WriteLine($"bookContainer.Value  = {(object)bookContainer.Value ?? "null"}");
  }
}