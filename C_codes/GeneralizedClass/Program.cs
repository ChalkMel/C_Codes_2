namespace GeneralizedClass;

class Program
{
  static void Main()
  {
    var stringIdBooks = new List<Book<string>>
    {
      new Book<string>("B001", "Мятная сказка", "Александр Полярный", 160),
      new Book<string>("B002", "1984", "Джордж Оруэлл", 320)
    };
    
    var intIdBooks = new List<Book<int>>
    {
      new Book<int>(1, "Преступление и наказание", "Фёдор Достоевский", 671),
      new Book<int>(2, "Тася и граф", "Арсений Попов", 358)
    };
    
    var guidIdBooks = new List<Book<Guid>>
    {
      new Book<Guid>(Guid.NewGuid(), "One Piece. Большой куш. Книга 1", "Эйитиро Ода", 608),
      new Book<Guid>(Guid.NewGuid(), "Анна Каренина", "Лев Толстой", 864)
    };

    Console.WriteLine("Книги с id-строкой:");
    foreach (var book in stringIdBooks)
    {
      Console.WriteLine(book);
    }

    Console.WriteLine();
    Console.WriteLine("Книги с id-числом:");
    foreach (var book in intIdBooks)
    {
      Console.WriteLine(book);
    }

    Console.WriteLine();
    Console.WriteLine("Книги с id-Guid:");
    foreach (var book in guidIdBooks)
    {
      Console.WriteLine(book);
    }
  }
}