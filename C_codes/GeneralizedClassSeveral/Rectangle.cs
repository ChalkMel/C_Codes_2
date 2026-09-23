namespace GeneralizedClassSeveral;
using System.Numerics;

public class Rectangle<T, K> : Figure
{
  public T Width { get; private set; }
  public K Height { get; private set; }

  public Rectangle(Vector2 center, T width, K height) : base(center)
  {
    Width = width;
    Height = height;
  }
  
  private float W => (float)Convert.ToDouble(Width);
  private float H => (float)Convert.ToDouble(Height);

  public override Vector2 MinPoint =>
    new Vector2(Center.X - W / 2f, Center.Y - H / 2f);

  public override Vector2 MaxPoint =>
    new Vector2(Center.X + W / 2f, Center.Y + H / 2f);

  public override string ToString()
  {
    return $"Rectangle: Center = ({Center.X}; {Center.Y}), Width = {Width}, Height = {Height}";
  }
}