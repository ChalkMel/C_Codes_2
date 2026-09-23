namespace GeneralizedMethod;
using System.Numerics;

public class Circle<T> : Figure
{
  public T Radius { get; private set; }

  public Circle(Vector2 center, T radius) : base(center)
  {
    Radius = radius;
  }
  
  public void SetRadius(T newRadius)
  {
    Radius = newRadius;
  }
  
  public double Area
  {
    get
    {
      double r = Convert.ToDouble(Radius);
      return Math.PI * r * r;
    }
  }

  public override string ToString()
  {
    return $"Center = ({Center.X}; {Center.Y}), Radius = {Radius}, Area = {Area:F4}";
  }
}