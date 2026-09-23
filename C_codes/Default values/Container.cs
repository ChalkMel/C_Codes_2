namespace Default_values;

public class Container<T>
{
  public T Value { get; set; }

  public Container(T value)
  {
    Value = value;
  }
  
  
  public void Reset()
  {
    Value = default(T);
  }
}