namespace GeneralizedClassSeveral;
using System.Numerics;

public class Square<T> : Figure
{
  public T Side { get; private set; }

  public Square(Vector2 center, T side) : base(center)
  {
    Side = side;
  }

  private float S => (float)Convert.ToDouble(Side);

  public override Vector2 MinPoint =>
    new Vector2(Center.X - S / 2f, Center.Y - S / 2f);

  public override Vector2 MaxPoint =>
    new Vector2(Center.X + S / 2f, Center.Y + S / 2f);
}
