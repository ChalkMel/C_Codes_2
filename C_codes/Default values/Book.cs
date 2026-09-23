namespace Default_values;

public class Book<T>
{
  public T Id { get; set; }
  public string Name { get; set; }
  public int PagesCount { get; set; }
  public string Author { get; set; }

  public Book(T id, string name, string author, int pagesCount)
  {
    Id = id;
    Name = name;
    Author = author;
    PagesCount = pagesCount;
  }

  public override string ToString()
  {
    return $"{Id} {Name}, {Author}, {PagesCount} страниц";
  }
}